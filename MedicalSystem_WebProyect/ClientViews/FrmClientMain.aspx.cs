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
    public partial class FrmClientMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            MedicalData medicalData = new MedicalData();
            Medical medical = new Medical();
            if (Session["IdUser"] != null)
            {
                medical = helper.SearchUser(int.Parse(Session["IdUser"].ToString()), medicalData.List());
                LkbUserConfig.Text = medical.UserName;
            }
                
        }

    }
}