using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace MedicalSystem_WebProyect.ClientViews
{
    public partial class FrmUserConfig : System.Web.UI.Page
    {
        public FrmUserConfig() { medicalData = new MedicalData(); }
        private Medical user;
        public MedicalData medicalData;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Helper helper = new Helper();
                user = helper.SearchUser(int.Parse(Session["IdUser"].ToString()), medicalData.List());
                if (!IsPostBack) charge_Elements();
            }catch(Exception ex) { throw ex; }
        }
        
        private void charge_Elements()
        {
            TxtId.Text = user.Id.ToString();
            TxtFullName.Text = user.FullName;
            TxtUserName.Text = user.UserName;
            TxtEmail.Text = user.Email;
            TxtPass.Text = user.PropPassword;
            TxtDni.Text = user.Dni;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Medical medical = new Medical();
                medical.Id = int.Parse(TxtId.Text);
                medical.FullName = TxtFullName.Text;
                medical.UserName = TxtUserName.Text;
                medical.Email = TxtEmail.Text;
                medical.PropPassword = TxtPass.Text;
                medical.Dni = TxtDni.Text;

                medicalData.MedicalUpdateSP(medical);
                Response.Redirect("FrmClientMain.aspx");
            }catch(Exception ex ) { throw ex; }
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmClientMain.aspx");
        }
    }
}