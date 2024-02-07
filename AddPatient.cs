using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project
{
    public partial class AddPatient : UserControl
    {
        private Department _selected_department = null;
        private HumenInfo _prev_form_ref = null;
        public AddPatient()
        {
            InitializeComponent();
        }
        public void set_prev_form_ref(HumenInfo prev)
        {
            this._prev_form_ref = prev;
        }
        public void set_selected_department(Department selected_department)
        {
            this._selected_department = selected_department;
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.clear_all();
        }
        static public bool isAllLettersWithSpaceKey(string check)
        {
            return check.All(c => char.IsLetter(c) || c == ' ');
        }
        static public bool isAllNumbers(string check)
        {
            return check.All(c => char.IsNumber(c));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (isAllLettersWithSpaceKey(this.textBox1.Text))
            {
                if (isAllNumbers(this.textBox4.Text))
                {
                    Patients new_patient = new Patients(this.textBox1.Text, double.Parse(this.textBox4.Text), this.textBox2.Text);
                    this._selected_department.addPetient(new_patient);
                    this.Hide();
                    this._selected_department.AmountOfPetients++;
                    this._prev_form_ref.refresh_grid();
                }
                else
                {
                    MessageBox.Show("Invalid age.");
                    this.textBox4.Clear();
                }
            }
            else
            {
                MessageBox.Show("Invalid patient name.");
                this.textBox1.Clear();
            }
        }
        public void clear_all()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox4.Clear();
        }
    }
}
