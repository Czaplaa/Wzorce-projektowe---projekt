using Projekt.IteratorDir.Classes;
using Newtonsoft.Json;
using Projekt.Builders;
using Projekt.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt.Forms
{
    public partial class fAddStudent : Form
    {
        public fAddStudent()
        {
            InitializeComponent();
        }

        private void bAddStudent_Click(object sender, EventArgs e)
        {
            Task addClassAsync = Task.Run(() => AddStudent(sender, e));   //równoległe dodawanie dodawanie obiektu do jsona
            Close();
        }

        private void bAddNextStudent_Click(object sender, EventArgs e)
        {
            Task addClassAsync = Task.Run(() => AddStudent(sender, e));   //równoległe dodawanie dodawanie obiektu do jsona
            tbFirstName.Text = "";
            tbLastName.Text = "";
            tbPESEL.Text = "";
            tbResidentialAddress.Text = "";
            tbPhoneNo.Text = "";
            tbEmail.Text = "";
        }

        private void AddStudent(object sender, EventArgs e)
        {
            StudentBuilder studentBuilder = new StudentBuilder();
            var studentObj = studentBuilder
                .FirstName(tbFirstName.Text)
                .LastName(tbLastName.Text)
                .PESEL(tbPESEL.Text)
                .Address(tbResidentialAddress.Text)
                .Phone(tbPhoneNo.Text)
                .Email(tbEmail.Text)
                .Build();

            string stringFromFile, stringToSave;

            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\micha\Desktop\Projekt.json"))          //odczyt z pliku json
                {
                    stringFromFile = sr.ReadToEnd();                                                        
                }

                List<School> schoolList = JsonConvert.DeserializeObject<List<School>>(stringFromFile);      
                schoolList[0].classList[0].studentList.Add(studentObj);                                     //niedokończony wybór szkoły, klasy
                schoolList[0].classList[0].studentList.OrderBy(x => x.lastName);                            //sortowanie po nazwisku
                
                IteratorClass iterator = new IteratorClass(schoolList[0].classList[0].studentList);
                int i = 0;
                iterator.First();
                while (!iterator.IsDone())
                {
                    iterator.collection[i].ID = i;  //iterowanie po uczniach w celu nadania każdemu z nich numeru dziennika
                    i++;
                    iterator.Next();
                }
                

                stringToSave = JsonConvert.SerializeObject(schoolList);

                using (StreamWriter sw = new StreamWriter(@"C:\Users\micha\Desktop\Projekt.json"))
                {
                    sw.Write(stringToSave);
                    sw.Close();
                }
            }
            catch (Exception)
            {
                
            }
        } 
    }
}
