using Schooler.Database.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schooler.Shared
{
    public partial class EditSchoolboyForm : Form
    {
        private schoolboy schoolboy = null;
        public EditSchoolboyForm()
        {
            InitializeComponent();
        }
        
        public EditSchoolboyForm(schoolboy schoolboy)
        {
            InitializeComponent();
            this.schoolboy = schoolboy;
            this.Text = "Редактировать учащегося";
            this.EditButton.Text = "Изменить";
        }

        private void EditSchoolboyForm_Load(object sender, EventArgs e)
        {
            if (schoolboy != null) FillInfo();
        }

        private void FillInfo()
        {
            SurnameTextBox.Text = schoolboy.surname;
            NameTextBox.Text = schoolboy.name;
            PatronymicTextBox.Text = schoolboy.patronymic;
            BirthDateTimePicker.Value = schoolboy.date_of_birth;
            PhoneMaskedTextBox.Text = schoolboy.contacts;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            // Добавление
            if (schoolboy == null)
            {

            }
            // Изменение
            else
            {

            }
        }
    }
}
