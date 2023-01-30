using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;
using System.Runtime.InteropServices.ComTypes;

namespace MedicalSystem_WebProyect.ClientViews
{
    public partial class FrmGvData : System.Web.UI.Page
    {
        public FrmGvData()
        {
            medicalData = new MedicalData();
            appointmentData = new AppointmentData();
        }
        //properties
        public int content;
        private int IdUser;
        private MedicalData medicalData;
        private AppointmentData appointmentData;
        //Charge Methods
        protected void Page_Load(object sender, EventArgs e)
        {
            IdUser = int.Parse(Session["IdUser"].ToString());
            content = int.Parse(Request.QueryString["content"]);
            Charge_GvData();
            if (!IsPostBack) { Charge_DdlCamp(); Charge_DdlPatient(); }
            if (Session["Error"] != null) Response.Redirect("../FrmError.aspx");
        }
        private void Charge_DdlCamp()
        {
            DdlCamp.Items.Add("State");
            DdlCamp.Items.Add("Query Type");
        }
        private void Charge_DdlPatient()
        {
            try
            {
                if (content == 2)
                {
                    PatientData patientData = new PatientData();
                    DdlPatients.DataSource = patientData.PatientList();
                    DdlPatients.DataTextField = "FullName";
                    DdlPatients.DataValueField = "Id";
                    DdlPatients.DataBind();
                }
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }

        }
        private void Charge_GvData()
        {
            try {
                if (content == 1)
                {
                    GvData.DataSource = appointmentData.AppointmentListSP(); GvData.DataBind();
                }
                else if (content == 2)
                {
                    GvData2.DataSource = medicalData.Read_Patients_(int.Parse(Session["IdUser"].ToString())); GvData2.DataBind();
                }
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }
        private void Charge_GvData(List<Appointment>list)
        {
            try { GvData.DataSource = list; GvData.DataBind(); }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }
        private void Charge_GvData(List<Patient> list)
        {
            try { GvData2.DataSource = list; GvData2.DataBind();}
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }
        

        //Events
        protected void DdlCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DdlCriterion.Items.Clear();
                if (DdlCamp.SelectedItem.ToString() == "State")
                {
                    StateData stateData = new StateData();
                    DdlCriterion.DataSource = stateData.QueryList();
                    DdlCriterion.DataTextField = "Name";
                    DdlCriterion.DataValueField = "Id";
                    DdlCriterion.DataBind();
                }
                else if (DdlCamp.SelectedItem.ToString() == "Query Type")
                {
                    QueryData queryData = new QueryData();
                    DdlCriterion.DataSource = queryData.QueryList();
                    DdlCriterion.DataTextField = "Name";
                    DdlCriterion.DataValueField = "IdQuery";
                    DdlCriterion.DataBind();
                }
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }

        protected void GvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(GvData.SelectedRow.Cells[1].Text);
            Response.Redirect("FrmAppointmentRegister.aspx?Id=" + Id + "&&content=" + content);
        }

        protected void GvData2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                int Id = int.Parse(GvData2.SelectedRow.Cells[1].Text);
                medicalData.Delete_Patient_from_PatientList(int.Parse(Session["IdUser"].ToString()), Id);
                Charge_GvData();
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmClientMain.aspx");
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (content == 1) Response.Redirect("FrmAppointmentRegister.aspx?content=" + content);
            else if (content == 2) Response.Redirect("FrmMedicalPatientRegister.aspx?content=" + content);
        }

        protected void CkbAdvancedFilter_CheckedChanged(object sender, EventArgs e)
        {
            //refactorizacion: creo que con un array se podria simplificar(para pensar).
            if (CkbAdvancedFilter.Checked == true)
            {
                LblCamp.Visible = true;
                DdlCamp.Visible = true;
                LblCriterion.Visible = true;
                DdlCriterion.Visible = true;
                BtnApply.Visible = true;
                TxtFastFilter.Enabled = false;
            }
            if (CkbAdvancedFilter.Checked == false)
            {
                LblCamp.Visible = false;
                DdlCamp.Visible = false;
                LblCriterion.Visible = false;
                DdlCriterion.Visible = false;
                BtnApply.Visible = false;
                TxtFastFilter.Enabled = true;
            }
        }

        protected void TxtFastFilter_TextChanged(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            try
            {
                if (content == 1)
                {
                    Charge_GvData(helper.FastFilter(TxtFastFilter.Text, appointmentData.AppointmentListSP()));
                }
                else
                {
                    Charge_GvData(
                        helper.FastFilter(
                            TxtFastFilter.Text,
                            medicalData.Read_Patients_(IdUser)));
                }
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }

        protected void BtnApply_Click(object sender, EventArgs e)
        {
            try
            {
                string camp = DdlCamp.SelectedItem.ToString();
                string criterion = DdlCriterion.SelectedValue;
                GvData.DataSource = appointmentData.AppointmentListFilter(camp, criterion);
                GvData.DataBind();
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }

        protected void CbxAddPatient_CheckedChanged(object sender, EventArgs e)
        {
            if(CbxAddPatient.Checked == true)
            {
                LblPatients.Visible = true;
                DdlPatients.Visible =true;
                BtnAddPatient.Visible = true;
            }
            else
            {
                LblPatients.Visible = false;
                DdlPatients.Visible = false;
                BtnAddPatient.Visible = false;
            }
        }

        protected void BtnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = int.Parse(DdlPatients.SelectedValue.ToString());
                Helper helper = new Helper();
                if (helper.validate_if_Patient_exist(Id, medicalData.Read_Patients_(IdUser)) == false)
                {
                    medicalData.Insert_To_PatientList(Id, int.Parse(Session["IdUser"].ToString()));
                    Charge_GvData();
                }
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }
    }
}