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
    public partial class Form1 : Form
    {
        // 1. Criamos a variável aqui em cima (Escopo Global da Classe)
        private double totalItens = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Opcional: Garantir que a label comece com 0
            //label1.Text = "Total: 0";
        }

        // 2. Este é o evento do BOTÃO de confirmar (ex: "Adicionar ao Pedido")
        // Certifique-se de dar um duplo clique no botão no Design para gerar esse evento
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Soma o valor atual do NumericUpDown ao nosso total
            //totalItens += nudPastelCarne.Value;

            // Atualiza a Label para mostrar ao usuário
            label2.Text = $"Total: {totalItens}";

            // Opcional: Feedback visual ou resetar o seletor
            // numericUpDown1.Value = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void label2_Click(object sender, EventArgs e) { }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e) { }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(nudPastelCarne.Value) * 10.00;
            listCarrinho.Items.Add("Pastel de Carne: R$ " + preco + "\n");
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(nudPastelPizza.Value) * 10.00;
            listCarrinho.Items.Add("Pastel de Pizza: R$ " + preco);
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(nudPastelQuatroQueijo.Value) * 15.00;
            listCarrinho.Items.Add("Pastel Quatro Queijo: R$ " + preco);
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;

        }

        private void nudPastelCarne_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nudPastelQueijo_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdicionarPastelQueijo_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(nudPastelQueijo.Value) * 10.00;
            listCarrinho.Items.Add("Pastel de Queijo: R$ " + preco);
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void btnAdicionarPastelCalabresaCheddar_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(nudPastelCalabresaCheddar.Value) * 25.00;
            listCarrinho.Items.Add("Pastel de Calabresa + Cheddar: R$ " + preco);
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void btnAdicionarPastelPernil_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(nudPastelPernil.Value) * 30.00;
            listCarrinho.Items.Add("Pastel de Carne: R$ " + preco);
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void listCarrinho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}