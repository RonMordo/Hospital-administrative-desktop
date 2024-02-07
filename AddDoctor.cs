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
    public partial class AddDoctor : UserControl
    {
        private Department _selected_department = null;
        private HumenInfo _prev_form_ref = null;
        public AddDoctor()
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
        private void button2_Click(object sender, EventArgs e)
        {
            this.clear_all();
        }
        public void clear_all()
        {
            this.textBox1.Clear();
            this.textBox2.Clear();
            this.textBox4.Clear();
        }
        static public bool isAllLettersWithSpaceKey(string check)
        {
            return check.All(c => char.IsLetter(c) || c == ' ');
        }
        static public bool isAllNumbers(string check)
        {
            return check.All(c => char.IsNumber(c));
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAllLettersWithSpaceKey(this.textBox1.Text))
            {
                if (isAllNumbers(this.textBox4.Text))
                {
                    Doctors user_doctor = new Doctors(this.textBox1.Text, double.Parse(this.textBox4.Text), this.textBox2.Text);
                    this._selected_department.getDoctorsList().Add(user_doctor);
                    this.Hide();
                    this._selected_department.AmountOfDoctors++;
                    this._prev_form_ref.refresh_grid();
                }
                else
                {
                    MessageBox.Show("Invalid age.");
                }
            }
            else
            {
                MessageBox.Show("Invalid name");
            }
        }
    }
}
