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


    }
}
