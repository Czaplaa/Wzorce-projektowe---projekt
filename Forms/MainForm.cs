using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt.Forms;
using Projekt.Lists;
using Projekt.Classes;
using Newtonsoft.Json;
using System.IO;

namespace Projekt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dodajSzkołęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddSchool addSchool = new fAddSchool();
            addSchool.ShowDialog();
        }

        private void dodajKlasęToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddClass addClass = new fAddClass();
            addClass.ShowDialog();
        }

        private void dodajUczniówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAddStudent addStudent = new fAddStudent();
            addStudent.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string stringFromFile;
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\micha\Desktop\Projekt.json"))
                {
                    stringFromFile = sr.ReadToEnd();
                }

                List<School> schoolList = JsonConvert.DeserializeObject<List<School>>(stringFromFile);
                List<Class> classList = schoolList[0].classList;

                string serializedClassList = JsonConvert.SerializeObject(classList);

                DataTable dtSchoolList = (DataTable)JsonConvert.DeserializeObject(stringFromFile, (typeof(DataTable)));
                DataTable dtClassList = (DataTable)JsonConvert.DeserializeObject(serializedClassList, (typeof(DataTable)));

                dgvSchool.DataSource = dtSchoolList;
                dgvClass.DataSource = dtClassList;
            }
            catch (Exception)
            {

            }   
        }
    }
}
