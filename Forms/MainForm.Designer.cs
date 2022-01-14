namespace Projekt
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSchool = new System.Windows.Forms.DataGridView();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dodajSzkołęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajKlasęToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajUczniówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSchool
            // 
            this.dgvSchool.AllowUserToAddRows = false;
            this.dgvSchool.AllowUserToDeleteRows = false;
            this.dgvSchool.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchool.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchool.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchool.Location = new System.Drawing.Point(34, 77);
            this.dgvSchool.MultiSelect = false;
            this.dgvSchool.Name = "dgvSchool";
            this.dgvSchool.ReadOnly = true;
            this.dgvSchool.RowHeadersVisible = false;
            this.dgvSchool.RowHeadersWidth = 51;
            this.dgvSchool.RowTemplate.Height = 29;
            this.dgvSchool.ShowEditingIcon = false;
            this.dgvSchool.Size = new System.Drawing.Size(900, 188);
            this.dgvSchool.TabIndex = 0;
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Location = new System.Drawing.Point(34, 294);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 29;
            this.dgvClass.Size = new System.Drawing.Size(900, 188);
            this.dgvClass.TabIndex = 1;
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3});
            this.dgvStudent.Location = new System.Drawing.Point(298, 515);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 29;
            this.dgvStudent.Size = new System.Drawing.Size(260, 188);
            this.dgvStudent.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Uczniowie";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 607);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajSzkołęToolStripMenuItem,
            this.dodajKlasęToolStripMenuItem,
            this.dodajUczniówToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1073, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dodajSzkołęToolStripMenuItem
            // 
            this.dodajSzkołęToolStripMenuItem.Name = "dodajSzkołęToolStripMenuItem";
            this.dodajSzkołęToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.dodajSzkołęToolStripMenuItem.Text = "Dodaj szkołę";
            this.dodajSzkołęToolStripMenuItem.Click += new System.EventHandler(this.dodajSzkołęToolStripMenuItem_Click);
            // 
            // dodajKlasęToolStripMenuItem
            // 
            this.dodajKlasęToolStripMenuItem.Name = "dodajKlasęToolStripMenuItem";
            this.dodajKlasęToolStripMenuItem.Size = new System.Drawing.Size(101, 24);
            this.dodajKlasęToolStripMenuItem.Text = "Dodaj klasę";
            this.dodajKlasęToolStripMenuItem.Click += new System.EventHandler(this.dodajKlasęToolStripMenuItem_Click);
            // 
            // dodajUczniówToolStripMenuItem
            // 
            this.dodajUczniówToolStripMenuItem.Name = "dodajUczniówToolStripMenuItem";
            this.dodajUczniówToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.dodajUczniówToolStripMenuItem.Text = "Dodaj ucznia";
            this.dodajUczniówToolStripMenuItem.Click += new System.EventHandler(this.dodajUczniówToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Szkoły";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 635);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.dgvSchool);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSchool;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dodajKlasęToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajUczniówToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ToolStripMenuItem dodajSzkołęToolStripMenuItem;
    }
}
