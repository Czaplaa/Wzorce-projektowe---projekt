using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using Projekt.Builders;
using Projekt.Classes;
using Projekt.Lists;

namespace Projekt.Forms
{
    public partial class fAddSchool : Form
    {
        public fAddSchool()
        {
            InitializeComponent();
        }


        private void bAddSchool_Click(object sender, EventArgs e)
        {
            if (DataValidation())
            {
                SchoolBuilder schoolBuilder = new SchoolBuilder();
                var schoolObj = schoolBuilder
                    .Name(tbSchoolName.Text)
                    .Address(tbSchoolAddress.Text)
                    .Email(tbSchoolEmail.Text)
                    .Phone(tbSchoolPhoneNo.Text)
                    .Fax(tbSchoolFax.Text)
                    .Build();

                string stringFromFile, stringToSave;

                try
                {
                    using (StreamReader sr = new StreamReader(@"C:\Users\micha\Desktop\Projekt.json"))
                    {
                        stringFromFile = sr.ReadToEnd();
                    }

                    List<School> schoolList = JsonConvert.DeserializeObject<List<School>>(stringFromFile);
                    schoolList.Add(schoolObj);

                    SaveJsonToFile(schoolList);
                }
                catch (Exception)       
                {
                    List<School> schoolList = new List <School>();    
                    schoolList.Add (schoolObj);

                    SaveJsonToFile(schoolList);
                }

                void SaveJsonToFile(List<School> schoolList)
                {
                    stringToSave = JsonConvert.SerializeObject(schoolList);

                    using (StreamWriter sw = new StreamWriter(@"C:\Users\micha\Desktop\Projekt.json"))
                    {
                        sw.WriteLine(stringToSave);
                        sw.Close();
                    }
                }
            }
        }

        private void bAddNextSchool_Click(object sender, EventArgs e)
        {

        }

        private bool DataValidation()
        {
            if(tbSchoolName.Text.Trim() == "" && tbSchoolAddress.Text.Trim() == "")
            {
                return false;
            }

            return true;
        }
    }
}
