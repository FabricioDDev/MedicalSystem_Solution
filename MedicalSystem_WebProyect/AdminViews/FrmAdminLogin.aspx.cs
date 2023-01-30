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
    public partial class FrmAdminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Error"] != null) Response.Redirect("../FrmError.aspx", false);
        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            AdminUserValidation();
        }
        private void AdminUserValidation()
        {
            AdminData adminData = new AdminData();
            try
            {
                Admin admin = adminData.ListSP().Find(x => x.Email == TxtEmail.Text && x.PropPassword == TxtPass.Text);

                if (admin != null) { Session.Add("Admin", admin); Response.Redirect("FrmAdminMain.aspx", false); }
                else{ LblWarning.Text = "The User or Pass is Wrong. Try again!"; LblWarning.Visible = true; }
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
            
        }

        protected void BtnClient_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ClientViews/FrmClientLogin.aspx", false);
        }
    }
}