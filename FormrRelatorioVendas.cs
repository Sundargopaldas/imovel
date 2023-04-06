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
    public partial class FormrRelatorioVendas : Form
    {
        public FormrRelatorioVendas()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ImoveisVendidos;
            ImoveisVendidos = Convert.ToDecimal(textBox2.Text);
            ImoveisVendidos = ImoveisVendidos * 6 / 100;
            textBox3.Text = Convert.ToString(ImoveisVendidos);
        }
    }
}
