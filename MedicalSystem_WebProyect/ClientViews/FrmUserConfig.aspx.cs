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
        private Medical User;
        protected void Page_Load(object sender, EventArgs e)
        {
            search_User();
           if(!IsPostBack) charge_Elements();
        }
        private void search_User()
        {
            //refactorizar: hacer funcion en clase helper
            MedicalData medicalData = new MedicalData();
            User = medicalData.List().Find(x => x.Id == int.Parse(Session["IdUser"].ToString()));
        }
        private void charge_Elements()
        {
            TxtId.Text = User.Id.ToString();
            TxtFullName.Text = User.FullName;
            TxtUserName.Text = User.UserName;
            TxtEmail.Text = User.Email;
            TxtPass.Text = User.PropPassword;
            TxtDni.Text = User.Dni;
        }

        protected void BtnSave_Click(object sender, EventArgs e)
        {
            Medical medical = new Medical();
            medical.Id = int.Parse(TxtId.Text);
            medical.FullName= TxtFullName.Text;
            medical.UserName= TxtUserName.Text;
            medical.Email= TxtEmail.Text;
            medical.PropPassword = TxtPass.Text;
            medical.Dni= TxtDni.Text;

            MedicalData medicalData = new MedicalData();
            medicalData.MedicalUpdateSP(medical);
            Response.Redirect("FrmClientMain.aspx");
        }

        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmClientMain.aspx");
        }
    }
}