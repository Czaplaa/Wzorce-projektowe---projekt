using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Projekt.Builders;
using Projekt.Classes;

namespace Projekt.Forms
{
    public partial class fAddClass : Form
    {
        public fAddClass()
        {
            InitializeComponent();
        }

        private void fAddClass_Click(object sender, EventArgs e)
        {
            Task addClassAsync = Task.Run(() => AddClass(sender, e));   //równoległe dodawanie dodawanie obiektu do jsona
            Close();
        }

        private void bAddNextClass_Click(object sender, EventArgs e)
        {
            Task addClassAsync = Task.Run(() => AddClass(sender, e));   //równoległe dodawanie dodawanie obiektu do jsona
            tbName.Text = "";
            tbType.Text = "";
        }

        private void AddClass(object sender, EventArgs e)
        {
            ClassBuilder classBuilder = new ClassBuilder();
            var classObj = classBuilder
                .Name(tbName.Text)
                .Type(tbType.Text)
                .Build();

            string stringFromFile, stringToSave;

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\micha\Desktop\Projekt.json")) //deserializacja jsona dodanie klasy 
                {                                                                                  //i ponowna serializacja
                    stringFromFile = sr.ReadToEnd();
                }

                List<School> schoolList = JsonConvert.DeserializeObject<List<School>>(stringFromFile);
                schoolList[0].classList.Add(classObj);

                stringToSave = JsonConvert.SerializeObject(schoolList);

                using (StreamWriter sw = new StreamWriter(@"C:\Users\micha\Desktop\Projekt.json"))
                {
                    sw.WriteLine(stringToSave);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
