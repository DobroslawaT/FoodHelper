using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using FoodHelper;
public partial class Form1 : Form
{
    public string ChoiceRecipe;
}
namespace FoodHelper
{
    public partial class Form1 : Form
    {
/*
        internal System.Windows.Forms.ComboBox ComboBox1;

        // Initialize ComboBox1.
        private void InitializeComboBox()
        {
            this.ComboBox1 = new ComboBox();
            this.ComboBox1.Location = new System.Drawing.Point(128, 48);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(100, 21);
            this.ComboBox1.TabIndex = 0;
            this.ComboBox1.Text = "Typical";
            string[] installs = new string[] { "Typical", "Compact", "Custom" };
            ComboBox1.Items.AddRange(installs);
            this.Controls.Add(this.ComboBox1);

            // Hook up the event handler.
            this.ComboBox1.DropDown +=
                new System.EventHandler(ComboBox1_DropDown);
        }

        // Handles the ComboBox1 DropDown event. If the user expands the  
        // drop-down box, a message box will appear, recommending the
        // typical installation.
        private void ComboBox1_DropDown(object sender, System.EventArgs e)
        {
            MessageBox.Show("Typical installation is strongly recommended.",
            "Install information", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        */


        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("IceTea");
            comboBox1.Items.Add("Sushi");
            comboBox1.Items.Add("Japanese omlet");
            comboBox1.Items.Add("Rice with strawberries");
            comboBox1.Items.Add("Lava cake");
        }

        private void comboBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           //// Form2 f2 = new Form2();
            //f2.ShowDialog();
            //var form = FoodHelper.Form2();
            //form.Show(); // Show form using new variable
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            this.Hide();
            f2.ShowDialog();
        }
    }
}
