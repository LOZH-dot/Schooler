using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schooler.Director
{
    public partial class DirectorMainForm : Form
    {
        public DirectorMainForm()
        {
            InitializeComponent();
        }

        private void DirectorMainForm_Load(object sender, EventArgs e)
        {
            UpdateSchoolboysDataGridView();
            UpdateClassesDataGridView();
        }

        /// <summary>
        /// Обновляет таблицу SchoolboysDataGridView
        /// </summary>
        private async void UpdateSchoolboysDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                SchoolboysDataGridView.DataSource = await db.schoolboy.ToListAsync();
        }

        /// <summary>
        /// Обновляет таблицу ClassesDataGridView
        /// </summary>
        private async void UpdateClassesDataGridView()
        {
            using (Database.Model.Context db = new Database.Model.Context())
                ClassesDataGridView.DataSource = await db._class
                    .Include(x => x.schoolboy)
                    .Include(x => x.class_lesson).ToListAsync();
        }

        private void DirectorMainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StateSingleton.getInstance().authForm.Close();
        }

        private void DirectorMainForm_Resize(object sender, EventArgs e)
        {
            SchoolboysDataGridViewPanel.Width = this.Width / 2;
            ClassesDataGridViewPanel.Width = this.Width / 2;
        }

        private void AddClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shared.EditClassForm ecf = new Shared.EditClassForm();
            ecf.FormClosed += Ecf_FormClosed;
            ecf.ShowDialog();
        }

        private void Ecf_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateClassesDataGridView();
        }

        /// <summary>
        /// Открытие формы изменения по двойному щелку на строку таблицы ClassesDataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClassesDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(ClassesDataGridView.Rows[e.RowIndex].Cells["id_class"].Value.ToString());

            _class cCl = null;
            using (Database.Model.Context db = new Database.Model.Context())
                cCl = db._class.Find(id);

            Shared.EditClassForm ecf = new Shared.EditClassForm(cCl);
            ecf.FormClosed += Ecf_FormClosed;
            ecf.ShowDialog();
        }
    }
}
