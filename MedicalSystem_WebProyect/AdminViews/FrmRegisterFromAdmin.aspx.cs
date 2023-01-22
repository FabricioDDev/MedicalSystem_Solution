using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Messaging;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmRegisterFromAdmin : System.Web.UI.Page
    {
        private int Content;
        private MedicalData medicalData;
        private PatientData patientData;
        List<TextBox> list = new List<TextBox>();
       
        private void Data()
        {
            medicalData = new MedicalData();
            patientData = new PatientData();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Admin"] == null)
                    Response.Redirect("FrmAdminLogin.aspx", false);
                Content = Request.QueryString["content"] != null ? int.Parse(Request.QueryString["content"]) : 0;
                OcultControlls();
                Data();
                user_Controlls_Charge();
                if (!IsPostBack && Request.QueryString["Id"] != null)
                {
                    LblTitle.Text = "Update";
                    ChargeControlls();
                }
            }
            catch (Exception) { Response.Redirect("FrmError.aspx"); }
        }
        private void user_Controlls_Charge()
        {
            if (Content == 1)
            {
                
                list.Add(TxtFullName);
                list.Add(TxtEmail);
                list.Add(TxtPass);
                list.Add(TxtDni);
            }
            else if(Content == 2)
            {
                
                list.Add(TxtFullName);
                list.Add(TxtEmail);
                list.Add(TxtDni);
                list.Add(TxtYears);
                list.Add(TxtMedicalPlan);
                list.Add(TxtPhoneNumber);
                list.Add(TxtAddress);
            }
        }
        public void ChargeControlls()
        {
            try
            {
                if (Content == 1)
                {
                    Medical Obj = medicalData.List().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
                    TxtId.Text = Obj.Id.ToString();
                    TxtFullName.Text = Obj.FullName;
                    TxtEmail.Text = Obj.Email;
                    TxtUserName.Text = Obj.UserName;
                    TxtPass.Text = Obj.PropPassword;
                    TxtDni.Text = Obj.Dni;
                }
                else if (Content == 2)
                {
                    Patient Obj = patientData.PatientList().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
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
            catch (Exception) { Response.Redirect("FrmError.aspx"); }   
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
        private bool validate_Controlls()
        {
            Helper helper = new Helper();
            bool result = true;
            try
            {
                foreach (TextBox textbox in list)
                {
                    if (!result) return result;

                    if (textbox.CssClass != "numericControll")
                    { result = helper.validate_Long_textbox(textbox.Text, 1, 20) ? true : false; }
                    if (textbox.CssClass == "numericControll")
                    { result = helper.validate_IsNumber(textbox.Text) ? true : false; }
                }
                return result;
            }
            catch (Exception) { Response.Redirect("FrmError.aspx"); }
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Medical medical = new Medical();
            Patient patient = new Patient();
            try
            {
                if (validate_Controlls())
                {
                    switch (Content)
                    {
                        case 1:
                            Medical medic = CreateMedicalObject();
                            if (Request.QueryString["Id"] != null)
                            {
                                medic.Id = int.Parse(TxtId.Text);
                                medicalData.MedicalUpdateSP(medic);
                            }
                            else medicalData.MedicalInsertSP(medic);
                            break;
                        case 2:
                            Patient pat = CreatePatientObject();
                            if (Request.QueryString["Id"] != null)
                            {
                                pat.Id = int.Parse(TxtId.Text);
                                patientData.PatientUpdateSP(pat);
                            }
                            else patientData.PatientInsertSP(pat);
                            break;
                        default:
                            break;
                    }
                    Response.Redirect("FrmGridView.aspx?content=" + Content);
                }
                else { LblWarning.Text = "Los datos ingresados son incorrectos. intentelo de nuevo."; }
            }
            catch (Exception) { Response.Redirect("FrmError.aspx"); }
        }
        private Medical CreateMedicalObject()
        {
            Medical medical = new Medical();
                medical.FullName = TxtFullName.Text;
                medical.Email = TxtEmail.Text;
                medical.UserName = TxtUserName.Text;
                medical.PropPassword = TxtPass.Text;
                medical.Dni = TxtDni.Text;
                return medical;
            
       }
        private Patient CreatePatientObject()
        {
            Patient patient = new Patient();
            patient.FullName = TxtFullName.Text;
            patient.Email = TxtEmail.Text;
            patient.Dni = TxtDni.Text;
            patient.Address = TxtAddress.Text;
            patient.years = TxtYears.Text;
            patient.MedicalPlan = TxtMedicalPlan.Text;
            patient.PhoneNumber = TxtPhoneNumber.Text;
            return patient;
        }
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmGridView.aspx?content=" + Content);
        }
    }
} 