using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHelper
{
    public partial class Form1 : Form
    {
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
            comboBox1.Items.Add("Rice sauce");
            comboBox1.Items.Add("Lemon Sorbet");
            comboBox1.Items.Add("Pina Colada");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form3 fo3 = new Form3())
            {
                fo3.chooseRecipe = comboBox1.Text;
                fo3.numberOfPortions = comboBox2.Text;
                Form3 f3 = new Form3();
                this.Hide();
                fo3.ShowDialog();
            }
        }
    }
}