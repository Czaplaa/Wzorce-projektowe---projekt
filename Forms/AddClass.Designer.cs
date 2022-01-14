namespace Projekt.Forms
{
    partial class fAddClass
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
            this.bAddClass = new System.Windows.Forms.Button();
            this.bAddNextClass = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            //this.tbSchoolAddress = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddClass
            // 
            this.bAddClass.Location = new System.Drawing.Point(401, 141);
            this.bAddClass.Name = "bAddClass";
            this.bAddClass.Size = new System.Drawing.Size(112, 29);
            this.bAddClass.TabIndex = 2;
            this.bAddClass.Text = "Dodaj klasę";
            this.bAddClass.UseVisualStyleBackColor = true;
            this.bAddClass.Click += new System.EventHandler(this.fAddClass_Click);
            // 
            // bAddNextClass
            // 
            this.bAddNextClass.Location = new System.Drawing.Point(231, 141);
            this.bAddNextClass.Name = "bAddNextClass";
            this.bAddNextClass.Size = new System.Drawing.Size(164, 29);
            this.bAddNextClass.TabIndex = 3;
            this.bAddNextClass.Text = "Dodaj kolejną klasę";
            this.bAddNextClass.UseVisualStyleBackColor = true;
            this.bAddNextClass.Click += new System.EventHandler(this.bAddNextClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wymagane";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nazwa klasy";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 63);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(238, 30);
            this.tbName.TabIndex = 0;
            // 
            // tbSchoolAddress
            // 
            //this.tbSchoolAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            //| System.Windows.Forms.AnchorStyles.Left) 
            //| System.Windows.Forms.AnchorStyles.Right)));
            //this.tbSchoolAddress.Location = new System.Drawing.Point(-795, -149);
            //this.tbSchoolAddress.Name = "tbSchoolAddress";
            //this.tbSchoolAddress.Size = new System.Drawing.Size(280, 27);
            //this.tbSchoolAddress.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbType);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcjonalne";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Profil klasy";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(6, 63);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(238, 30);
            this.tbType.TabIndex = 1;
            // 
            // fAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 188);
            //this.Controls.Add(this.tbSchoolAddress);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAddNextClass);
            this.Controls.Add(this.bAddClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "fAddClass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj klasę";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddClass;
        private System.Windows.Forms.Button bAddNextClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbName;
        //private System.Windows.Forms.TextBox tbSchoolAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbType;
    }
}