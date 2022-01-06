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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lClassName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddClass
            // 
            this.bAddClass.Location = new System.Drawing.Point(182, 142);
            this.bAddClass.Name = "bAddClass";
            this.bAddClass.Size = new System.Drawing.Size(112, 29);
            this.bAddClass.TabIndex = 1;
            this.bAddClass.Text = "Dodaj klasę";
            this.bAddClass.UseVisualStyleBackColor = true;
            this.bAddClass.Click += new System.EventHandler(this.fAddClass_Click);
            // 
            // bAddNextClass
            // 
            this.bAddNextClass.Location = new System.Drawing.Point(12, 142);
            this.bAddNextClass.Name = "bAddNextClass";
            this.bAddNextClass.Size = new System.Drawing.Size(164, 29);
            this.bAddNextClass.TabIndex = 2;
            this.bAddNextClass.Text = "Dodaj kolejną klasę";
            this.bAddNextClass.UseVisualStyleBackColor = true;
            this.bAddNextClass.Click += new System.EventHandler(this.bAddNextClass_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.lClassName);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 102);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wymagane";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 30);
            this.textBox1.TabIndex = 0;
            // 
            // lClassName
            // 
            this.lClassName.AutoSize = true;
            this.lClassName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lClassName.Location = new System.Drawing.Point(6, 36);
            this.lClassName.Name = "lClassName";
            this.lClassName.Size = new System.Drawing.Size(90, 20);
            this.lClassName.TabIndex = 0;
            this.lClassName.Text = "Nazwa klasy";
            // 
            // fAddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 193);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bAddNextClass);
            this.Controls.Add(this.bAddClass);
            this.Name = "fAddClass";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodaj klasę";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bAddClass;
        private System.Windows.Forms.Button bAddNextClass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lClassName;
    }
}