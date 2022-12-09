﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DomainModel;

namespace DataModel
{
    public class PatientData
    {
        public PatientData() { data = new DataAccess(); }
        private DataAccess data;

        public List<Patient> PatientListSP()
        {
            List<Patient> List = new List<Patient>();
            try
            {
                data.SP("PatientList");
                data.Read();
                while (data.PropReader.Read())
                {
                    Patient aux = new Patient();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.FullName = (string)data.PropReader["FullName"];
                    aux.Email = (string)data.PropReader["Email"];
                    aux.Dni = (string)data.PropReader["Dni"];
                    aux.years = (string)data.PropReader["Years"];
                    aux.MedicalPlan = (string)data.PropReader["MedicalPlan"];
                    aux.PhoneNumber = (string)data.PropReader["PhoneNumber"];
                    aux.Address = (string)data.PropReader["Address"];
                    List.Add(aux);
                }
                return List;
            }
            catch(Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}