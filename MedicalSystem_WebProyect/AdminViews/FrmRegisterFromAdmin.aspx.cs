using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmRegisterFromAdmin : System.Web.UI.Page
    {
        private int Content;
        protected void Page_Load(object sender, EventArgs e)
        {
            Content = Request.QueryString["content"] != null ? int.Parse(Request.QueryString["content"]) : 0;
            if(Content == 1)
            {
                LblYears.Visible = false;
                TxtYears.Visible= false;
                LblMedicalPlan.Visible=false;
                TxtMedicalPlan.Visible= false;
                LblPhoneNumber.Visible=false;
                TxtPhoneNumber.Visible= false;
                LblAddress.Visible=false;
                TxtAddress.Visible= false;
               
            }
            else if(Content == 2)
            {
                LblUserName.Visible = false;
                TxtUserName.Visible= false;
                LblPass.Visible=false;
                TxtPass.Visible = false;
            }
        }
    }
}