using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using System.Runtime.Remoting.Contexts;
using System.Data;

namespace MedicalSystem_WebProyect.ClientViews
{
    public partial class FrmAppointmentRegister : System.Web.UI.Page
    {
        public FrmAppointmentRegister()
        {
            medicalData= new MedicalData();
            appointmentData = new AppointmentData();
        }
        private Medical user;
        private MedicalData medicalData;
        private AppointmentData appointmentData;
        private int content;
        protected void Page_Load(object sender, EventArgs e)
        {
            content = int.Parse(Request.QueryString["content"]);
            if (!IsPostBack) {
                
                ChargeUser();
                Charge_Ddl();
            }
            if (Request.QueryString["Id"] != null && !IsPostBack) ChargeControlls();
        }
        private void Charge_Ddl()
        {
            try
            {
                StateData stateData = new StateData();
                QueryData queryData = new QueryData();

                DdlPatient.DataSource = medicalData.Read_Patients_(user.Id);
                DdlPatient.DataTextField = "FullName";
                DdlPatient.DataValueField = "Id";
                DdlPatient.DataBind();

                DdlState.DataSource = stateData.QueryList();
                DdlState.DataTextField = "Name";
                DdlState.DataValueField = "Id";
                DdlState.DataBind();

                DdlQuery.DataSource = queryData.QueryList();
                DdlQuery.DataTextField = "Name";
                DdlQuery.DataValueField = "IdQuery";
                DdlQuery.DataBind();
            }catch(Exception ex) { throw ex; }
        }
        private void ChargeUser()
        {
            Helper helper = new Helper();
            user = helper.SearchUser(
                int.Parse(Session["IdUser"].ToString()),
                medicalData.List()
                );
            TxtDoctor.Text = user.FullName;
        }
        private void ChargeControlls()
        {
            try {
                Appointment appointment = appointmentData.AppointmentListSP().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
                TxtId.Text = appointment.Id.ToString();
                TxtDate.Text = appointment.date.ToString("yyyy-MM-dd");
                TxtHour.Text = appointment.date.ToString("t");
                DdlPatient.SelectedValue = appointment.patient.Id.ToString();
                DdlState.SelectedValue = appointment.state.Id.ToString();
                DdlQuery.SelectedValue = appointment.query.IdQuery.ToString();
            }catch(Exception ex) { throw ex; }
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Appointment appointment = new Appointment();
                string date = TxtDate.Text + " " + TxtHour.Text + ":00";
                appointment.date = Convert.ToDateTime(date);
                appointment.patient = new Patient();
                appointment.patient.Id = int.Parse(DdlPatient.SelectedValue.ToString());
                appointment.medical = new Medical();
                appointment.medical.Id = int.Parse(Session["IdUser"].ToString());
                appointment.query = new Query();
                appointment.query.IdQuery = int.Parse(DdlQuery.SelectedValue.ToString());
                appointment.state = new State();
                appointment.state.Id = int.Parse(DdlState.SelectedValue.ToString());

                if (Request.QueryString["Id"] != null)
                {
                    appointment.Id = int.Parse(TxtId.Text);
                    appointmentData.AppointmentUpdateSP(appointment);
                    Response.Redirect("FrmGvData.aspx?content=" + content, false);
                }
                else
                {
                    appointmentData.AppointmentInsertSP(appointment);
                    Response.Redirect("FrmGvData.aspx?content=" + content, false);
                }
            }catch(Exception ex) { throw ex; }
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmGvData.aspx?content=" + content);
        }
    }
}