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
namespace Castle
{
    public partial class Form3Clientes : Form

    {
      static string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
     static string arquivo = "arquivo txt";
        string local = Path.Combine(pasta, arquivo);
        int id = 1;

        public Form3Clientes()
        {
            InitializeComponent();
        }

        private void Form3Clientes_Load(object sender, EventArgs e)
        {

            try
            {
                id = File.ReadLines(local).Count() + 1;
                textBox1.Text = Convert.ToString(id);
                textBox1.Enabled = false;
            }


            catch { 
            }
            textBox1.Text = Convert.ToString(1);
            textBox1.Enabled = false;
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e) // botão de cadastro de clientes
        {

            if (textBox2.Text == string.Empty || textBox3.Text == string.Empty || maskedTextBox1.Text == string.Empty || textBox5.Text == string.Empty || comboBox1.Text== string.Empty)
            {
                MessageBox.Show("POR FAVOR PREENCHA TODOS OS CAMPOS");
            }

            else
            {
                StreamWriter sw = new StreamWriter(local, true);
                sw.WriteLine(textBox2.Text + "-" + textBox3.Text + "-" + maskedTextBox1.Text + "-" + textBox5.Text + comboBox1.Text);
                sw.Close();
                MessageBox.Show("CADASTRO REALIZADO COM SUCESSO!");
                textBox2.Clear();
                textBox3.Clear();
                maskedTextBox1.Clear();
                textBox5.Clear();
                

            }

                id++;
            textBox1.Text = Convert.ToString(id);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           
        

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CADASTRAR_CLIENTE cc = new CADASTRAR_CLIENTE(textBox2.Text, textBox3.Text,maskedTextBox1.Text , textBox5.Text, comboBox1.Text);
            MessageBox.Show(cc.mensagem);
        }
    }
}
