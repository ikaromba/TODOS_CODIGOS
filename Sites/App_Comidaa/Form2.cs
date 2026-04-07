using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Comidaa
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = "Ikaro123";
            string senha1 = "Gustavao09";
            if(txtboxnomeusuario.Text == usuario &&  txtboxsenha.Text == senha1)
            {
                MessageBox.Show("login realizado com sucesso");
                Form1 homeForm = new Form1();
                homeForm.Show();
                this.Hide();
                //this.Close();
            }
            else if (txtboxnomeusuario.Text != usuario || txtboxsenha.Text != senha1)
            {
                MessageBox.Show("Senha ou usuário incorretas ");
            }
            else
            {
                MessageBox.Show("Senha e usuário incorretas ");
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtboxnomeusuario_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
