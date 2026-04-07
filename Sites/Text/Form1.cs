using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ofd_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Lê todo o conteúdo do arquivo selecionado e joga no RichTextBox
                richTextBox1.Text = System.IO.File.ReadAllText(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 1. Abre a janelinha para o usuário escolher onde salvar e o nome
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 2. Pega o caminho que o usuário escolheu e grava o texto lá
                // Se o arquivo não existir, o WriteAllText cria um novo automaticamente
                System.IO.File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);

                MessageBox.Show("Arquivo criado e salvo com sucesso!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Adiciona os nomes amigáveis ao ComboBox
            cbModos.Items.Add("Normal (Tile)");
            cbModos.Items.Add("Centralizar (Center)");
            cbModos.Items.Add("Esticar (Stretch)");
            cbModos.Items.Add("Ajustar (Zoom)");

            // Seleciona o primeiro por padrão
            cbModos.SelectedIndex = 0;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Imagens|*.jpg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbVisualizador.Image = Image.FromFile(ofd.FileName);
            }

        }
    }
}
