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

        }

        protected void BtnGo_Click(object sender, EventArgs e)
        {
            AdminData adminData = new AdminData();
            Admin admin = adminData.ListSP().Find(x => x.Email == TxtEmail.Text && x.PropPassword == TxtPass.Text);
            if (admin != null)
            {
                Session.Add("AdminUser", admin);
                Response.Redirect("FrmAdminMain.aspx", false);
            }
            else { TxtEmail.Text = "Vuelva a intentarlo"; }
        }
    }
}