namespace Projekt.Forms
{
    partial class fAddSchool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbRequired = new System.Windows.Forms.GroupBox();
            this.tbSchoolName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbSchoolAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAddSchool = new System.Windows.Forms.Button();
            this.gbRequired.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbRequired
            // 
            this.gbRequired.Controls.Add(this.tbSchoolName);
            this.gbRequired.Controls.Add(this.label1);
            this.gbRequired.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbRequired.Location = new System.Drawing.Point(12, 12);
            this.gbRequired.Name = "gbRequired";
            this.gbRequired.Size = new System.Drawing.Size(250, 125);
            this.gbRequired.TabIndex = 0;
            this.gbRequired.TabStop = false;
            this.gbRequired.Text = "Wymagane";
            // 
            // tbSchoolName
            // 
            this.tbSchoolName.Location = new System.Drawing.Point(6, 67);
            this.tbSchoolName.Name = "tbSchoolName";
            this.tbSchoolName.Size = new System.Drawing.Size(238, 30);
            this.tbSchoolName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nazwa szkoły";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbSchoolAddress);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 125);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcjonalne";
            // 
            // tbSchoolAddress
            // 
            this.tbSchoolAddress.Location = new System.Drawing.Point(6, 67);
            this.tbSchoolAddress.Name = "tbSchoolAddress";
            this.tbSchoolAddress.Size = new System.Drawing.Size(238, 30);
            this.tbSchoolAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adres";
            // 
            // bAddSchool
            // 
            this.bAddSchool.Location = new System.Drawing.Point(355, 161);
            this.bAddSchool.Name = "bAddSchool";
            this.bAddSchool.Size = new System.Drawing.Size(124, 29);
            this.bAddSchool.TabIndex = 2;
            this.bAddSchool.Text = "Dodaj szkołę";
            this.bAddSchool.UseVisualStyleBackColor = true;
            this.bAddSchool.Click += new System.EventHandler(this.bAddSchool_Click);
            // 
            // fAddSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 202);
            this.Controls.Add(this.bAddSchool);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbRequired);
            this.Name = "fAddSchool";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie szkoły";
            this.gbRequired.ResumeLayout(false);
            this.gbRequired.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbRequired;
        private System.Windows.Forms.TextBox tbSchoolName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbSchoolAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAddSchool;
    }
}