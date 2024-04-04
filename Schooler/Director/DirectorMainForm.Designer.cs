namespace Schooler.Director
{
    partial class DirectorMainForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SchoolboysDataGridViewPanel = new System.Windows.Forms.Panel();
            this.SchoolboysDataGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClassesDataGridViewPanel = new System.Windows.Forms.Panel();
            this.ClassesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.учащиесяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.классыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SchoolboysDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolboysDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.ClassesDataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 425);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SchoolboysDataGridViewPanel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Учащиеся";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SchoolboysDataGridViewPanel
            // 
            this.SchoolboysDataGridViewPanel.Controls.Add(this.SchoolboysDataGridView);
            this.SchoolboysDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SchoolboysDataGridViewPanel.Location = new System.Drawing.Point(3, 3);
            this.SchoolboysDataGridViewPanel.Name = "SchoolboysDataGridViewPanel";
            this.SchoolboysDataGridViewPanel.Size = new System.Drawing.Size(412, 393);
            this.SchoolboysDataGridViewPanel.TabIndex = 0;
            // 
            // SchoolboysDataGridView
            // 
            this.SchoolboysDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SchoolboysDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolboysDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SchoolboysDataGridView.Location = new System.Drawing.Point(0, 0);
            this.SchoolboysDataGridView.Name = "SchoolboysDataGridView";
            this.SchoolboysDataGridView.ReadOnly = true;
            this.SchoolboysDataGridView.Size = new System.Drawing.Size(412, 393);
            this.SchoolboysDataGridView.TabIndex = 0;
            this.SchoolboysDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchoolboysDataGridView_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ClassesDataGridViewPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Классы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClassesDataGridViewPanel
            // 
            this.ClassesDataGridViewPanel.Controls.Add(this.ClassesDataGridView);
            this.ClassesDataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ClassesDataGridViewPanel.Location = new System.Drawing.Point(3, 3);
            this.ClassesDataGridViewPanel.Name = "ClassesDataGridViewPanel";
            this.ClassesDataGridViewPanel.Size = new System.Drawing.Size(365, 393);
            this.ClassesDataGridViewPanel.TabIndex = 0;
            // 
            // ClassesDataGridView
            // 
            this.ClassesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ClassesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClassesDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ClassesDataGridView.Name = "ClassesDataGridView";
            this.ClassesDataGridView.ReadOnly = true;
            this.ClassesDataGridView.Size = new System.Drawing.Size(365, 393);
            this.ClassesDataGridView.TabIndex = 0;
            this.ClassesDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassesDataGridView_CellContentDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 25);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.учащиесяToolStripMenuItem,
            this.классыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // учащиесяToolStripMenuItem
            // 
            this.учащиесяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem1});
            this.учащиесяToolStripMenuItem.Name = "учащиесяToolStripMenuItem";
            this.учащиесяToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.учащиесяToolStripMenuItem.Text = "Учащиеся";
            // 
            // классыToolStripMenuItem
            // 
            this.классыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem});
            this.классыToolStripMenuItem.Name = "классыToolStripMenuItem";
            this.классыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.классыToolStripMenuItem.Text = "Классы";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.AddClassToolStripMenuItem_Click);
            // 
            // добавитьToolStripMenuItem1
            // 
            this.добавитьToolStripMenuItem1.Name = "добавитьToolStripMenuItem1";
            this.добавитьToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem1.Text = "Добавить";
            this.добавитьToolStripMenuItem1.Click += new System.EventHandler(this.AddSchoolboyToolStripMenuItem1_Click);
            // 
            // DirectorMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DirectorMainForm";
            this.Text = "Директор";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DirectorMainForm_FormClosed);
            this.Load += new System.EventHandler(this.DirectorMainForm_Load);
            this.Resize += new System.EventHandler(this.DirectorMainForm_Resize);
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SchoolboysDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolboysDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ClassesDataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel SchoolboysDataGridViewPanel;
        private System.Windows.Forms.DataGridView SchoolboysDataGridView;
        private System.Windows.Forms.Panel ClassesDataGridViewPanel;
        private System.Windows.Forms.DataGridView ClassesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem учащиесяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem классыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem1;
    }
}