using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmRegisterFromAdmin : System.Web.UI.Page
    {
        private int Content;
        protected void Page_Load(object sender, EventArgs e)
        {
            Content = Request.QueryString["content"] != null ? int.Parse(Request.QueryString["content"]) : 0;
            OcultControlls();
            if (Request.QueryString["Id"] != null)
            {
                LblTitle.Text = "Update";
                ChargeControlls();
            }
        }
        public void ChargeControlls()
        {
            if (Content == 1)
            {
                MedicalData medicalData = new MedicalData();
                Medical Obj = medicalData.ListSP().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
                TxtId.Text = Obj.Id.ToString();
                TxtFullName.Text = Obj.FullName;
                TxtEmail.Text = Obj.Email;
                TxtUserName.Text = Obj.UserName;
                TxtPass.Text = Obj.PropPassword;
                TxtDni.Text = Obj.Dni;
            }
            else if (Content == 2)
            {
                PatientData patientData = new PatientData();
                Patient Obj = patientData.PatientListSP().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
                TxtId.Text = Obj.Id.ToString();
                TxtFullName.Text = Obj.FullName;
                TxtDni.Text = Obj.Dni;
                TxtEmail.Text = Obj.Email;
                TxtMedicalPlan.Text = Obj.MedicalPlan;
                TxtPhoneNumber.Text = Obj.PhoneNumber;
                TxtYears.Text = Obj.years;
                TxtAddress.Text = Obj.Address;
            }
        }
        public void OcultControlls()
        {
            if (Content == 1)
            {
                LblYears.Visible = false;
                TxtYears.Visible = false;
                LblMedicalPlan.Visible = false;
                TxtMedicalPlan.Visible = false;
                LblPhoneNumber.Visible = false;
                TxtPhoneNumber.Visible = false;
                LblAddress.Visible = false;
                TxtAddress.Visible = false;

            }
            else if (Content == 2)
            {
                LblUserName.Visible = false;
                TxtUserName.Visible = false;
                LblPass.Visible = false;
                TxtPass.Visible = false;
            }
        }
    }
}