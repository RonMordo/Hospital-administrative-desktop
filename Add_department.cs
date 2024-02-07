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
    public partial class Add_department : Form
    {
        private Form1 refInstance;
        public Add_department(Form1 instance)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            refInstance = instance;
            this.Akg.Visible = false;
            this.CardioBox.Visible = false;
            this.Surgery.Visible = false;
            this.SurgeryBox.Visible = false;
            this.Neuro.Visible = false;
            this.NeuroBox.Visible = false;
            this.Silicone.Visible = false;
            this.SiliconeBox.Visible = false;
        }

        private string userChoiceDep = "None";
        private string userHospital = "None";        

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.userHospital = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.userChoiceDep = comboBox1.Text;
            if(this.userChoiceDep == "Cardiology")
            {
                this.Akg.Visible = true;
                this.CardioBox.Visible = true;
                this.Surgery.Visible = false;
                this.SurgeryBox.Visible = false;
                this.Silicone.Visible = false;
                this.SiliconeBox.Visible = false;
                this.Neuro.Visible = false;
                this.NeuroBox.Visible = false;
            }
            else if(this.userChoiceDep == "Surgery")
            {
                this.Akg.Visible = false;
                this.CardioBox.Visible = false;
                this.Surgery.Visible = true;
                this.SurgeryBox.Visible = true;
                this.Silicone.Visible = false;
                this.SiliconeBox.Visible = false;
                this.Neuro.Visible = false;
                this.NeuroBox.Visible = false;
            }
            else if(this.userChoiceDep == "Neuro Surgery")
            {
                this.Silicone.Visible = false;
                this.SiliconeBox.Visible = false;
                this.Neuro.Visible = true;
                this.NeuroBox.Visible = true;
                this.Surgery.Visible = true;
                this.SurgeryBox.Visible = true;
                this.Akg.Visible = false;
                this.CardioBox.Visible = false;
            }
            else if(this.userChoiceDep == "Plastic Surgery")
            {
                this.Neuro.Visible = false;
                this.NeuroBox.Visible = false;
                this.Silicone.Visible = true;
                this.SiliconeBox.Visible = true;
                this.Surgery.Visible = true;
                this.SurgeryBox.Visible = true;
                this.Akg.Visible = false;
                this.CardioBox.Visible = false;
            }
            else if(this.userChoiceDep == "None")
            {
                this.Akg.Visible = false;
                this.CardioBox.Visible = false;
                this.Surgery.Visible = false;
                this.SurgeryBox.Visible = false;
                this.Neuro.Visible = false;
                this.NeuroBox.Visible = false;
                this.Silicone.Visible = false;
                this.SiliconeBox.Visible = false;
            }
        }

        public void clearAll()
        {
            this.textBox1.Clear();
            this.CardioBox.Clear();
            this.NeuroBox.Clear();
            this.SiliconeBox.Clear();
            this.SurgeryBox.Clear();
            this.comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isAllLettersWithSpaceKey(this.textBox1.Text) && isAllNumbers(this.SiliconeBox.Text))
            {
                Department userDep = null;
                switch (userChoiceDep)
                {
                    case "Cardiology":
                        if (int.TryParse(CardioBox.Text, out int akgMachineAmount) && akgMachineAmount >= 0)
                        {
                            CardiologyDep newCardio = new CardiologyDep(this.userHospital);
                            newCardio.setAkgMachineAmount(akgMachineAmount);
                            userDep = newCardio;
                        }
                        else
                        {
                            MessageBox.Show("Invalid A.K.G  machine amount");
                        }
                        this.CardioBox.Clear();
                        break;
                    case "Surgery":
                        if (int.TryParse(SurgeryBox.Text, out int surgeryRoomsAmount) && surgeryRoomsAmount >= 0)
                        {
                            SurgeryDep newSurgery = new SurgeryDep(userHospital);
                            newSurgery.setSurgeryRoomsCount(surgeryRoomsAmount);
                            userDep = newSurgery;
                        }
                        else
                        {
                            MessageBox.Show("Invalid surgery rooms amount");
                        }
                        SurgeryBox.Clear();
                        break;
                    case "Plastic Surgery":
                        if (int.TryParse(SiliconeBox.Text, out int siliconeAmount) && siliconeAmount >= 0)
                        {
                            PlasticSurgery newPlastic = new PlasticSurgery(this.userHospital);
                            newPlastic.setSiliconeAmount(siliconeAmount);
                            newPlastic.setSurgeryRoomsCount(int.Parse(this.SurgeryBox.Text));
                            userDep = newPlastic;
                        }
                        else
                        {
                            MessageBox.Show("Invalid surgery rooms amount");
                        }
                        this.SiliconeBox.Clear();
                        break;
                    case "Neuro Surgery":
                        if (int.TryParse(NeuroBox.Text, out int MriAmount) && MriAmount >= 0)
                        {
                            NeuroSurgery newNeuro = new NeuroSurgery(this.userHospital);
                            newNeuro.setMriMachinesAmount(MriAmount);
                            newNeuro.setSurgeryRoomsCount(int.Parse(this.SurgeryBox.Text));
                            userDep = newNeuro;
                        }
                        else
                        {
                            MessageBox.Show("Invalid M.R.I machines amount");
                        }
                        this.NeuroBox.Clear();
                        break;
                }
                if (userDep != null)
                {
                    refInstance.addDepartmentToList(userDep);
                    refInstance.RefreshDataGridView();
                    MessageBox.Show("Department add Succesful!");
                }
                else
                {
                    MessageBox.Show("Something went wrong, please try again");
                }
                this.clearAll();
            }
            else
            {
                MessageBox.Show("Invalid hospital name");
            }
        }  
        static public bool isAllLettersWithSpaceKey(string check)
        {
            return check.All(c => char.IsLetter(c) || c == ' ');
        }
        static public bool isAllNumbers(string check)
        {
            return check.All(c => char.IsNumber(c));
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void SiliconeBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.clearAll();
        }

        private void Add_department_Load(object sender, EventArgs e)
        {

        }
    }
}