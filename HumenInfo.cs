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
    public partial class HumenInfo : Form
    {
        private Form1 _main_form_ref = null;
        private Department _selected_department = null;
        private Patients patient_selected = null;
        private Doctors doctor_selected = null;
        private bool _is_patient_open = false;
        private bool _is_doctors_open = false;
        private bool is_main_menu_pressed = false;
        public HumenInfo(Form1 main_form_ref, Department selected_department)
        {
            InitializeComponent();
            this._main_form_ref = main_form_ref;
            this._selected_department = selected_department;
            this.addPatient1.Hide();
            this.addPatient1.set_selected_department(this._selected_department);
            this.addPatient1.set_prev_form_ref(this);
            this.addDoctor1.Hide();
            this.addDoctor1.set_selected_department(this._selected_department);
            this.addDoctor1.set_prev_form_ref(this);
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.SelectionChanged += DataGridView2_SelectionChanged;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void HumenInfo_Load(object sender, EventArgs e)
        {
            if(this._selected_department != null)
            {
                this.dataGridView2.DataSource = this._selected_department.getPetientsList();
                this.dataGridView1.DataSource = this._selected_department.getDoctorsList();
            }                      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this._main_form_ref.RefreshDataGridView();
            this._main_form_ref.Show();
            this.is_main_menu_pressed = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            
            if (this._is_patient_open)
            {
                this.addPatient1.Hide();
                this._is_patient_open = false;
            }            
            else
            {
                this.addPatient1.Show();
                this._is_patient_open = true;
            }
        }
        private void DataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView1.ClearSelection();
            richTextBox1.Clear();
            if (this.dataGridView2.SelectedRows.Count > 0)
            {
                int selected_index = this.dataGridView2.CurrentCell.RowIndex;
                if (selected_index < this._selected_department.getPetientsList().Count)
                {
                    this.patient_selected = this._selected_department.getPetientsList()[selected_index];
                }
                else
                {
                    this.patient_selected = null;
                }
            }
            else
            {
                this.patient_selected = null;
            }
            if(this.patient_selected != null)
            {
                this.richTextBox1.AppendText(this.patient_selected.GetDiagnosis());
            }
            else
            {
                this.richTextBox1.Text = "Select a row for information.\n";
            }
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.dataGridView2.ClearSelection();
            richTextBox1.Clear();
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int selected_index = this.dataGridView1.CurrentCell.RowIndex;
                if (selected_index < this._selected_department.getDoctorsList().Count)
                {
                    this.doctor_selected = this._selected_department.getDoctorsList()[selected_index];
                }
                else
                {
                    this.doctor_selected = null;
                }
            }
            else
            {
                this.doctor_selected = null;
            }
            if(this.doctor_selected != null)
            {
                this.richTextBox1.AppendText(this.doctor_selected.GetProffesion);
            }
            else
            {
                this.richTextBox1.Text = "Select a row for information.\n";
            }
        }

        private void addPatient1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(this._selected_department != null && this.patient_selected != null)
            {
                this._selected_department.RemovePetient(this.patient_selected);
            }
        }
        public void refresh_grid()
        {
            this.dataGridView2.DataSource = null;
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = this._selected_department.getDoctorsList();
            this.dataGridView2.DataSource = this._selected_department.getPetientsList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addDoctor1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this._is_doctors_open)
            {
                this.addDoctor1.Hide();
                this._is_doctors_open = false;
            }
            else
            {
                this.addDoctor1.Show();
                this._is_doctors_open = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(this._selected_department != null && this.doctor_selected != null)
            {
                this._selected_department.getDoctorsList().Remove(doctor_selected); 
            }
            else
            {
                MessageBox.Show("Please select a doctor");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.is_main_menu_pressed == false)
            {
                MessageBox.Show("Please go back to main manu.");
                e.Cancel = true;
            }
            else
            {
                string fileName = "myData.bin";
                _main_form_ref.SaveListToFile(_main_form_ref.GetDepartments(), fileName);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(this.doctor_selected != null)
            {
                this.doctor_selected.GetProffesion = this.richTextBox1.Text;
            }
            else if(this.patient_selected != null)
            {
                this.patient_selected.set_diagnosis(this.richTextBox1.Text);
            }
            MessageBox.Show("Saved!");
        }
    }
}
