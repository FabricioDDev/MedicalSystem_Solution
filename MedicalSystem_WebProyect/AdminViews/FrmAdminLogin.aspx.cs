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
            AdminUserValidation();
        }
        private void AdminUserValidation()
        {
            AdminData adminData = new AdminData();
            Func<string, string, Admin, bool> GetAdm = (Email, Pass, adm) => adm.Email == Email && adm.PropPassword == Pass;
            foreach (Admin admin in adminData.ListSP())
            {
                if (!GetAdm(TxtEmail.Text, TxtPass.Text, admin)) TxtEmail.Text = "Vuelva a intentarlo";
                else Response.Redirect("FrmAdminMain.aspx", false);
            }
        }
    }
}