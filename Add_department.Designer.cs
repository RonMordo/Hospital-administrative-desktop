
namespace OOP_Project
{
    partial class Add_department
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_department));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Akg = new System.Windows.Forms.Label();
            this.CardioBox = new System.Windows.Forms.TextBox();
            this.Surgery = new System.Windows.Forms.Label();
            this.SurgeryBox = new System.Windows.Forms.TextBox();
            this.Neuro = new System.Windows.Forms.Label();
            this.NeuroBox = new System.Windows.Forms.TextBox();
            this.Silicone = new System.Windows.Forms.Label();
            this.SiliconeBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please fill out the form:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hospital Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose department:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "None",
            "Cardiology",
            "Surgery",
            "Neuro Surgery",
            "Plastic Surgery"});
            this.comboBox1.Location = new System.Drawing.Point(336, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(336, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(336, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Akg
            // 
            this.Akg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Akg.Location = new System.Drawing.Point(121, 194);
            this.Akg.Name = "Akg";
            this.Akg.Size = new System.Drawing.Size(154, 23);
            this.Akg.TabIndex = 8;
            this.Akg.Text = "A.K.G machines amount:";
            this.Akg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Akg.Click += new System.EventHandler(this.label4_Click);
            // 
            // CardioBox
            // 
            this.CardioBox.Location = new System.Drawing.Point(336, 197);
            this.CardioBox.Name = "CardioBox";
            this.CardioBox.Size = new System.Drawing.Size(121, 20);
            this.CardioBox.TabIndex = 9;
            this.CardioBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Surgery
            // 
            this.Surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surgery.Location = new System.Drawing.Point(121, 194);
            this.Surgery.Name = "Surgery";
            this.Surgery.Size = new System.Drawing.Size(157, 23);
            this.Surgery.TabIndex = 10;
            this.Surgery.Text = "Surgery rooms amount:";
            this.Surgery.Click += new System.EventHandler(this.label5_Click);
            // 
            // SurgeryBox
            // 
            this.SurgeryBox.Location = new System.Drawing.Point(336, 197);
            this.SurgeryBox.Name = "SurgeryBox";
            this.SurgeryBox.Size = new System.Drawing.Size(121, 20);
            this.SurgeryBox.TabIndex = 11;
            this.SurgeryBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Neuro
            // 
            this.Neuro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neuro.Location = new System.Drawing.Point(109, 238);
            this.Neuro.Name = "Neuro";
            this.Neuro.Size = new System.Drawing.Size(166, 23);
            this.Neuro.TabIndex = 12;
            this.Neuro.Text = "M.R.I machines amount:";
            this.Neuro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Neuro.Click += new System.EventHandler(this.label6_Click);
            // 
            // NeuroBox
            // 
            this.NeuroBox.Location = new System.Drawing.Point(336, 238);
            this.NeuroBox.Name = "NeuroBox";
            this.NeuroBox.Size = new System.Drawing.Size(121, 20);
            this.NeuroBox.TabIndex = 13;
            this.NeuroBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Silicone
            // 
            this.Silicone.AutoSize = true;
            this.Silicone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Silicone.Location = new System.Drawing.Point(163, 244);
            this.Silicone.Name = "Silicone";
            this.Silicone.Size = new System.Drawing.Size(112, 17);
            this.Silicone.TabIndex = 14;
            this.Silicone.Text = "Silicone amount:";
            this.Silicone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Silicone.Click += new System.EventHandler(this.label7_Click);
            // 
            // SiliconeBox
            // 
            this.SiliconeBox.Location = new System.Drawing.Point(336, 240);
            this.SiliconeBox.Name = "SiliconeBox";
            this.SiliconeBox.Size = new System.Drawing.Size(121, 20);
            this.SiliconeBox.TabIndex = 15;
            this.SiliconeBox.TextChanged += new System.EventHandler(this.SiliconeBox_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(182, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(121, 41);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Add_department
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(688, 451);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SiliconeBox);
            this.Controls.Add(this.Silicone);
            this.Controls.Add(this.NeuroBox);
            this.Controls.Add(this.Neuro);
            this.Controls.Add(this.SurgeryBox);
            this.Controls.Add(this.Surgery);
            this.Controls.Add(this.CardioBox);
            this.Controls.Add(this.Akg);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Add_department";
            this.Text = "Add_department";
            this.Load += new System.EventHandler(this.Add_department_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Akg;
        private System.Windows.Forms.TextBox CardioBox;
        private System.Windows.Forms.Label Surgery;
        private System.Windows.Forms.TextBox SurgeryBox;
        private System.Windows.Forms.Label Neuro;
        private System.Windows.Forms.TextBox NeuroBox;
        private System.Windows.Forms.Label Silicone;
        private System.Windows.Forms.TextBox SiliconeBox;
        private System.Windows.Forms.Button button3;
    }
}