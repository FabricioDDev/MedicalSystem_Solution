﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmGridView : System.Web.UI.Page
    {
        private int Content = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            Content = Request.QueryString["content"] != null ? int.Parse(Request.QueryString["content"]) : 0;
            GV_Charge();
        }
        private void GV_Charge()
        {
            if (Content == 1)
            {
                MedicalData medicalData = new MedicalData();
                GvData.DataSource = medicalData.ListSP();
                LblTitle.Text = "Doctors";
            }
            else if (Content == 2)
            {
                PatientData patientData = new PatientData();
                GvData.DataSource = patientData.PatientListSP();
                LblTitle.Text = "Patients";
            }
            GvData.DataBind();
        }


        protected void GvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void TxtFastFilter_TextChanged(object sender, EventArgs e)
        {
            Helper helper = new Helper();

            if (Content == 1)
            {
                MedicalData medicalData = new MedicalData();
                GvData.DataSource = helper.FastFilter(TxtFastFilter.Text, medicalData.ListSP());
                GvData.DataBind();
            }
            else
            {
                PatientData patientData = new PatientData();
                GvData.DataSource = helper.FastFilter(TxtFastFilter.Text, patientData.PatientListSP());
                GvData.DataBind();
            }
        }
    }
}