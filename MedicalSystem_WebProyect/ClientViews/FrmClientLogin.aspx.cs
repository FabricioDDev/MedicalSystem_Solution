using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;
using DomainModel;

namespace MedicalSystem_WebProyect.ClientViews
{
    public partial class FrmClientLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            MedicalData medicalData = new MedicalData();
            try
            {
                int Id = helper.ValidateUser(TxtEmail_User.Text, TxtPassword.Text, medicalData.List());
                if (Id != 0) { Session.Add("IdUser", Id); Response.Redirect("FrmClientMain.aspx", false); }
                else TxtEmail_User.Text = "Vuelva a intentarlo";
            }
            catch (Exception ex) { Session.Add("Error", ex.ToString()); }
        }

        protected void BtnAsAdmin_Click(object sender, EventArgs e)
        {
            Response.Redirect("../AdminViews/FrmAdminLogin.aspx", false);
        }
    }
}