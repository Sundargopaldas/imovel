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
    public partial class Form2Castle : Form
    {
        public Form2Castle()
        {
            InitializeComponent();
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongTimeString();
            label5.Text = DateTime.Now.ToLongDateString();
            label6.Text = Program.nome;
            label6.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5Imoveis f5imoveis = new Form5Imoveis();
            f5imoveis.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
  
           Form3Clientes f3clientes = new Form3Clientes();
            f3clientes.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4Simulação f4simulação = new Form4Simulação();
            f4simulação.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormrRelatorioVendas fRVendas = new FormrRelatorioVendas(); 
            
            
            fRVendas.Show();
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
