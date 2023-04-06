using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Castle
{
    public partial class Form1Login : Form
    {
        public Form1Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "luis" && textBox2.Text == "566575")
            {
                Program.nome = textBox1.Text;
                Form2Castle f2Castle = new Form2Castle();
                f2Castle.Show();
                this.Hide();
           
            }
            else
            {
                MessageBox.Show("usuário ou senha inválidos");

                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;   
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
