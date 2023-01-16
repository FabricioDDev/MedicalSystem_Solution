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
        //property
        public int content;
        private MedicalData medicalData = new MedicalData();
        private AppointmentData appointmentData = new AppointmentData();
        //Charge Functions
        protected void Page_Load(object sender, EventArgs e)
        {
            content = int.Parse(Request.QueryString["content"]);
            Charge_GvData();
            if (!IsPostBack) { Charge_DdlCamp(); Charge_DdlPatient(); }

        }
        private void Charge_DdlCamp()
        {
            DdlCamp.Items.Add("State");
            DdlCamp.Items.Add("Query Type");
        }
        private void Charge_DdlPatient()
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
        private void Charge_GvData()
        {
            if (content == 1)
            {
                GvData.DataSource = appointmentData.AppointmentListSP(); GvData.DataBind();
            }
            else if (content == 2)
            {
                GvData2.DataSource = medicalData.Read_Patients_(int.Parse(Session["IdUser"].ToString())); GvData2.DataBind();
            }
        }
        private void Charge_GvData(List<Appointment>list)
        {
            GvData.DataSource = list;
            GvData.DataBind();
        }
        private void Charge_GvData(List<Patient> list)
        {
            GvData2.DataSource = list;
            GvData2.DataBind();
        }
        private bool validate_if_Patient_exist(int Idp)
        {
            Patient Patient = medicalData.Read_Patients_(int.Parse(Session["IdUser"].ToString())).Find(x => x.Id == Idp );
            if (Patient != null) return true;
            else return false;
        }

        //Events
        protected void DdlCamp_SelectedIndexChanged(object sender, EventArgs e)
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

        protected void GvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(GvData.SelectedRow.Cells[1].Text);
            Response.Redirect("FrmAppointmentRegister.aspx?Id=" + Id + "&&content=" + content);
        }

        protected void GvData2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(GvData2.SelectedRow.Cells[1].Text);
            medicalData.Delete_Patient_from_PatientList(int.Parse(Session["IdUser"].ToString()),Id);
            Charge_GvData();
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
            if(content == 1)
            {
                Charge_GvData(helper.FastFilter(TxtFastFilter.Text, appointmentData.AppointmentListSP()));
            }
            else
            {
                Charge_GvData(
                    helper.FastFilter(
                        TxtFastFilter.Text,
                        medicalData.Read_Patients_(
                            int.Parse(Session["IdUser"].ToString()))));
            }
        }

        protected void BtnApply_Click(object sender, EventArgs e)
        {
            string camp = DdlCamp.SelectedItem.ToString();
            string criterion = DdlCriterion.SelectedValue;
            GvData.DataSource = appointmentData.AppointmentListFilter(camp, criterion);
            GvData.DataBind();
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
            int Id = int.Parse(DdlPatients.SelectedValue.ToString());
            if (validate_if_Patient_exist(Id) == false)
            {
                medicalData.Insert_To_PatientList(Id, int.Parse(Session["IdUser"].ToString()));
                Charge_GvData();
            }
        }
    }
}