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
    public partial class Form4Simulação : Form
    {
        public Form4Simulação()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal ValorImovel;
            decimal rendacliente;
            int anos;
            decimal minimo;
            decimal prestação;

            ValorImovel = Convert.ToDecimal(textBox1.Text);
            rendacliente = Convert.ToDecimal(textBox2.Text);
            anos = Convert.ToInt32(textBox3.Text);

            prestação = ValorImovel / anos * 12;
            minimo = rendacliente * 30 / 100;

            string[] pr;
            pr = Convert.ToString(prestação).Split(',');

            textBox4.Text = "R$ " + pr[0] + " , " + pr[1].Substring(0, 3);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
