namespace Projekt.Forms
{
    partial class fAddStudent
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
            this.bAddStudent = new System.Windows.Forms.Button();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbPESEL = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.bAddNextStudent = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbResidentialAddress = new System.Windows.Forms.TextBox();
            this.tbPhoneNo = new System.Windows.Forms.TextBox();
            this.lResidentialAddress = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddStudent
            // 
            this.bAddStudent.Location = new System.Drawing.Point(389, 284);
            this.bAddStudent.Name = "bAddStudent";
            this.bAddStudent.Size = new System.Drawing.Size(123, 29);
            this.bAddStudent.TabIndex = 4;
            this.bAddStudent.Text = "Dodaj ucznia";
            this.bAddStudent.UseVisualStyleBackColor = true;
            this.bAddStudent.Click += new System.EventHandler(this.bAddStudent_Click);
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lFirstName.Location = new System.Drawing.Point(6, 36);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(38, 20);
            this.lFirstName.TabIndex = 2;
            this.lFirstName.Text = "Imię";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lLastName.Location = new System.Drawing.Point(6, 107);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(72, 20);
            this.lLastName.TabIndex = 3;
            this.lLastName.Text = "Nazwisko";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbPESEL);
            this.groupBox1.Controls.Add(this.tbLastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbFirstName);
            this.groupBox1.Controls.Add(this.lFirstName);
            this.groupBox1.Controls.Add(this.lLastName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wymagane";
            // 
            // tbPESEL
            // 
            this.tbPESEL.Location = new System.Drawing.Point(6, 206);
            this.tbPESEL.Name = "tbPESEL";
            this.tbPESEL.Size = new System.Drawing.Size(238, 30);
            this.tbPESEL.TabIndex = 3;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(6, 130);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(238, 30);
            this.tbLastName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "PESEL";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(6, 59);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(238, 30);
            this.tbFirstName.TabIndex = 1;
            // 
            // bAddNextStudent
            // 
            this.bAddNextStudent.Location = new System.Drawing.Point(182, 284);
            this.bAddNextStudent.Name = "bAddNextStudent";
            this.bAddNextStudent.Size = new System.Drawing.Size(201, 29);
            this.bAddNextStudent.TabIndex = 5;
            this.bAddNextStudent.Text = "Dodaj kolejnego ucznia";
            this.bAddNextStudent.UseVisualStyleBackColor = true;
            this.bAddNextStudent.Click += new System.EventHandler(this.bAddNextStudent_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.tbResidentialAddress);
            this.groupBox2.Controls.Add(this.tbPhoneNo);
            this.groupBox2.Controls.Add(this.lResidentialAddress);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 248);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcjonalne";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(6, 206);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(238, 30);
            this.tbEmail.TabIndex = 2;
            // 
            // tbResidentialAddress
            // 
            this.tbResidentialAddress.Location = new System.Drawing.Point(6, 59);
            this.tbResidentialAddress.Name = "tbResidentialAddress";
            this.tbResidentialAddress.Size = new System.Drawing.Size(238, 30);
            this.tbResidentialAddress.TabIndex = 0;
            // 
            // tbPhoneNo
            // 
            this.tbPhoneNo.Location = new System.Drawing.Point(6, 130);
            this.tbPhoneNo.Name = "tbPhoneNo";
            this.tbPhoneNo.Size = new System.Drawing.Size(238, 30);
            this.tbPhoneNo.TabIndex = 1;
            // 
            // lResidentialAddress
            // 
            this.lResidentialAddress.AutoSize = true;
            this.lResidentialAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lResidentialAddress.Location = new System.Drawing.Point(6, 36);
            this.lResidentialAddress.Name = "lResidentialAddress";
            this.lResidentialAddress.Size = new System.Drawing.Size(139, 20);
            this.lResidentialAddress.TabIndex = 8;
            this.lResidentialAddress.Text = "Adres zamieszkania";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(6, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Telefon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(6, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // fAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 329);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAddNextStudent);
            this.Controls.Add(this.bAddStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fAddStudent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj ucznia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddStudent;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bAddNextStudent;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbResidentialAddress;
        private System.Windows.Forms.Label lResidentialAddress;
        private System.Windows.Forms.TextBox tbPESEL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhoneNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}