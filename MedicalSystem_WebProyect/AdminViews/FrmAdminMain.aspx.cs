using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmAdminMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] == null)
                Response.Redirect("FrmAdminLogin.aspx", false);
            if (Session["Error"] != null) Response.Redirect("../FrmError.aspx", false);
        }

        protected void BtnDoc_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmGridView.aspx?content=" + 1);
        }

        protected void BtnPatient_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmGridView.aspx?content=" + 2);
        }

        protected void BtnExit_Click(object sender, EventArgs e)
        {
            Session.Remove("Admin");
            Response.Redirect("FrmAdminLogin.aspx");
        }
    }
}