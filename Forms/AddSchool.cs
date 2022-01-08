using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Projekt.Builders;
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
            SchoolBuilder schoolBuilder = new SchoolBuilder();
            var schoolObj = schoolBuilder.Name(tbSchoolName.Text)
                .Address(tbSchoolAddress.Text)
                .Email(tbSchoolEmail.Text)
                .Phone(tbSchoolPhoneNo.Text)
                .Fax(tbSchoolFax.Text)
                .Build();

        }
    }
}
