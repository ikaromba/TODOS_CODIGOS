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

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Verifica se algo está selecionado
            if (listCarrinho.SelectedIndex != -1)
            {
                // Pega o texto do item selecionado (ex: "Pastel de Carne: R$ 30,00")
                string itemSelecionado = listCarrinho.SelectedItem.ToString();

                // 2. Tenta extrair o valor numérico após o "R$ " para subtrair do total
                try
                {
                    string[] partes = itemSelecionado.Split('$');
                    if (partes.Length > 1)
                    {
                        double valorRemovido = Convert.ToDouble(partes[1].Trim());
                        totalItens -= valorRemovido; // Subtrai do total acumulado
                        lblTotal.Text = "R$ " + totalItens.ToString("F2"); // Atualiza a label
                    }
                }
                catch
                {
                    // Se der erro na conversão, apenas ignoramos a subtração
                }

                // 3. Remove o item fisicamente da lista
                listCarrinho.Items.RemoveAt(listCarrinho.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item na lista para remover!", "Aviso");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(pesp.Value) * 8.00;
            listCarrinho.Items.Add("Pespsi_2L: R$ " + preco + "\n");
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(cocaca.Value) * 12.00;
            listCarrinho.Items.Add("Coca_2L: R$ " + preco + "\n");
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(su.Value) * 10.00;
            listCarrinho.Items.Add("Suco_1L: R$ " + preco + "\n");
            totalItens += preco;

            lblTotal.Text = "R$ " + totalItens;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cocaca_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }
    }
    }