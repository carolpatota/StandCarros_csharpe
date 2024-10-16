using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.IO;

namespace Agenda_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void LimparCampos()
        {
            txb_marca.Clear();
            txb_modelo.Clear();
            msk_b_matricula.Clear();
            msk_b_km.Clear();
            btn_adicionar.Text = "Adicionar";
            list_marca.Enabled = true;
            list_modelo.Enabled = true;
            list_matricula.Enabled = true;
            list_km.Enabled = true;
            btn_alterar.Enabled = true;
        }
        private void DesabilitarListas()
        {
            list_marca.Enabled = false;
            list_modelo.Enabled = false;
            list_matricula.Enabled = false;
            list_km.Enabled = false;
            btn_alterar.Enabled = false;
        }
       
        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //verificar se a marca esta preenchida
            if (txb_marca.Text.Length == 0)
            {
                MessageBox.Show("A marca do veiculo deve ser obrigatoriamente preenchida", "Confirmar Marca",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_marca.Focus();
                return;
            }
            //verificar se o modelo esta preenchido
            if (txb_modelo.Text.Length == 0)
            {
                MessageBox.Show("O modelo do veiculo deve ser obrigatoriamente preenchido", "Confirmar Modelo",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                txb_modelo.Focus();
                return;
            }
            //verificar se  matricula esta preenchida
            if (msk_b_matricula.Text.Length < 8)
            {
                MessageBox.Show("Matricula invalida", "Validar Matricula",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                msk_b_matricula.Focus();
                return;
            }
            //verificar se o campos km foi devidamente preenchido
            if (msk_b_km.Text.Length == 0)
            {
                MessageBox.Show("Quilometragem Invalida", "Validar KM",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                msk_b_km.Focus();
                return;
            }
            if (btn_adicionar.Text == "Atualizar")
            {
                list_marca.Items[list_marca.SelectedIndex] = txb_marca.Text;
                list_modelo.Items[list_marca.SelectedIndex] = txb_modelo.Text;
                list_matricula.Items[list_marca.SelectedIndex] = msk_b_matricula.Text;
                list_km.Items[list_marca.SelectedIndex] = msk_b_km.Text;
                LimparCampos();
                return;
            }
            //adicionar elementos as listas
            list_marca.Items.Add(txb_marca.Text);
            list_modelo.Items.Add(txb_modelo.Text);
            list_matricula.Items.Add(msk_b_matricula.Text);
            list_km.Items.Add(msk_b_km.Text);
            LimparCampos();
        }
       //sincronizar listas
        private void list_marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_modelo.SelectedIndex = list_marca.SelectedIndex;
            list_matricula.SelectedIndex = list_marca.SelectedIndex;
            list_km.SelectedIndex = list_marca.SelectedIndex;
        }
        private void list_modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_marca.SelectedIndex = list_modelo.SelectedIndex;
            list_matricula.SelectedIndex = list_modelo.SelectedIndex;
            list_km.SelectedIndex = list_modelo.SelectedIndex;
        }
        private void list_matricula_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_marca.SelectedIndex = list_matricula.SelectedIndex;
            list_modelo.SelectedIndex = list_matricula.SelectedIndex;
            list_km.SelectedIndex = list_matricula.SelectedIndex;
        }
        private void list_km_SelectedIndexChanged(object sender, EventArgs e)
        {
            list_modelo.SelectedIndex = list_km.SelectedIndex;
            list_matricula.SelectedIndex = list_km.SelectedIndex;
            list_marca.SelectedIndex = list_km.SelectedIndex;
        }
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void btn_alterar_Click(object sender, EventArgs e)
        {
            if (list_marca.SelectedIndex < 0)
            {
                MessageBox.Show("A lista esta vazia ou nao existe nenhum item selecionado",
                    "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DesabilitarListas();
            txb_marca.Text = list_marca.SelectedItem.ToString();
            txb_modelo.Text = list_modelo.SelectedItem.ToString();
            msk_b_matricula.Text = list_matricula.SelectedItem.ToString();
            msk_b_km.Text = list_km.SelectedItem.ToString();
            btn_adicionar.Text = "Atualizar";
        }

        private void btn_eliminar_Click_1(object sender, EventArgs e)
        {
            if (list_marca.SelectedIndex < 0)
            {
                MessageBox.Show("A lista esta azia ou nenhum item esta selecionado",
                    "Atencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indice = list_marca.SelectedIndex;

            list_marca.Items.RemoveAt(indice);
            list_modelo.Items.RemoveAt(indice);
            list_matricula.Items.RemoveAt(indice);
            list_km.Items.RemoveAt(indice);

            MessageBox.Show("Contacto Eliminado",
                    "Eliminar contacto", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage_1(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font f1 = new Font("Comic Sans MS", 16);
            Font f2 = new Font("Comic Sans MS", 13);
            Font f3 = new Font("Comic Sans MS", 11);

            e.Graphics.DrawString("Stand Aguiar, Ltda", f1, new SolidBrush(Color.Red), 100, 100);

            e.Graphics.DrawString("Listagem de Veiculos Disponiveis", f2, new SolidBrush(Color.DarkOrange), 100, 150);
  
            e.Graphics.DrawString("Marca", f2, new SolidBrush(Color.MediumPurple), 100, 200);
            e.Graphics.DrawString("Modelo", f2, new SolidBrush(Color.MediumPurple), 300, 200);
            e.Graphics.DrawString("Matricula", f2, new SolidBrush(Color.MediumPurple), 500, 200);
            e.Graphics.DrawString("KMs Atuais", f2, new SolidBrush(Color.MediumPurple), 700, 200);
            e.Graphics.DrawLine(new Pen(Color.Blue), 100, 250, 800, 250);

            int linha = 300;

            for (int i = 0; i < list_marca.Items.Count; i++)
            {
                e.Graphics.DrawString(list_marca.Items[i].ToString(), f3, new SolidBrush(Color.Green),
                    100, linha);
                e.Graphics.DrawString(list_modelo.Items[i].ToString(), f3, new SolidBrush(Color.Green),
                    300, linha);
                e.Graphics.DrawString(list_matricula.Items[i].ToString(), f3, new SolidBrush(Color.Green),
                   500, linha);
                e.Graphics.DrawString(list_km.Items[i].ToString(), f3, new SolidBrush(Color.Green),
                   700, linha);

                linha += 50;
               
            }
            e.Graphics.DrawLine(new Pen(Color.Blue), 100, linha+15, 800, linha+15);
            e.Graphics.DrawString("Fim da impressao", f3, new SolidBrush(Color.Red),
               100, linha+30);
        }

        private void btn_imprimir_Click_1(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void msk_b_matricula_TextChanged(object sender, EventArgs e)
        {
            msk_b_matricula.Text = msk_b_matricula.Text.ToUpper();    
        }

        private void btn_importar_Click(object sender, EventArgs e)
        {
            StreamReader fic = new StreamReader("contactos.txt");

            do
            {
                string linha = fic.ReadLine();
                string[] colunas = linha.Split('|');

                list_marca.Items.Add(colunas[0]);
                list_modelo.Items.Add(colunas[1]);
                list_matricula.Items.Add(colunas[2]);
                list_km.Items.Add(colunas[3]);
            } while (fic.Peek() != -1);
            fic.Close();
            MessageBox.Show("Dados imortados com sucesso.", "Importacao",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_exportar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Esta operacao elimina todos os dados do destino. Pretende continuar?", "Exportar dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            StreamWriter fic = new StreamWriter("contactos.txt");

            for(int i=0; i<list_marca.Items.Count; i++)
            {
                fic.WriteLine(list_marca.Items[i].ToString() + "|" +
                    list_modelo.Items[i].ToString() + "|" +
                    list_matricula.Items[i].ToString() + "|" +
                    list_km.Items[i].ToString());
            }
            fic.Close();
            MessageBox.Show("Exportacao efetuada com sucesso", "Exportacao",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
