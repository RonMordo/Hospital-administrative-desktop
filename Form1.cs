using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_Project
{
    public partial class Form1 : Form
    {
        private Login LoginFormRef = null;
        private bool isLogedOut { get; set; } = false;
        private bool isclicked = false;
        Department isSelected = null;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dataGridView1.Hide();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.richTextBox1.Hide();
        }
        public Form1(Login LoginForm)
        {
            this.LoginFormRef = LoginForm;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.dataGridView1.Hide();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
            this.richTextBox1.Hide();
            this.label3.Hide();
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
        }
        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }
        public BindingList<Department> _allDepartments = new BindingList<Department>();
        public BindingList<Department> GetDepartments()
        {
            return this._allDepartments;
        }        
        public void addDepartmentToList(Department newDepartment)
        {
            this._allDepartments.Add(newDepartment);
        }
        private void SetDataGridViewFont()
        {
            Font font = new Font("Arial", 12, FontStyle.Regular);
            dataGridView1.DefaultCellStyle.Font = font;
        }
        public void SaveListToFile(BindingList<Department> myList, string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, myList);
            }
        }
        private void LoadListFromFile(string fileName)
        {
            try
            {
                using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    this._allDepartments = (BindingList<Department>)binaryFormatter.Deserialize(fileStream);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show($"File not found: {fileName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadListFromFile("myData.bin");
            this.dataGridView1.DataSource = _allDepartments;
            this.RefreshDataGridView();
            this.SetDataGridViewFont();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_department adding = new Add_department(this);
            adding.Show();
        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                this.isSelected = this._allDepartments[selectedIndex];
            }            
            if(this.isSelected != null)
            {
                string info = this.isSelected.ShowInfo();
                AppendTextToRichTextBox(richTextBox1, info);
            }            
        }
        private void AppendTextToRichTextBox(RichTextBox richTextBox, string text)
        {
            richTextBox.AppendText(text + Environment.NewLine);
            richTextBox.ScrollToCaret();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.LoginFormRef.Show();
            this.isLogedOut = true;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && this.isLogedOut == false)
            {
                MessageBox.Show("Please log out");
                e.Cancel = true;
            }
            else
            {
                string fileName = "myData.bin";
                SaveListToFile(_allDepartments, fileName);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(this.isclicked == false)
            {
                this.dataGridView1.Show();
                this.isclicked = true;
                this.richTextBox1.Show();
                this.label3.Show();
            }
            else
            {
                this.dataGridView1.Hide();
                this.isclicked = false;
                this.richTextBox1.Hide();
                this.label3.Hide();
            }
            
        }
        public void RefreshDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = _allDepartments;
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(this.isSelected == null)
            {
                MessageBox.Show("Please mark the row you want to remove");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {isSelected.getHospitalName()} ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this._allDepartments.Remove(isSelected);
                    isSelected = null;
                    this.RefreshDataGridView();
                    this.richTextBox1.Clear();
                }
            }                        
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.isSelected != null)
            {
                HumenInfo humen_info_form = new HumenInfo(this, this.isSelected);
                this.Hide();
                humen_info_form.Show();
            }
            else
            {
                MessageBox.Show("Please select a department.");
            }
        }
    }
}
