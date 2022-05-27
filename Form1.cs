using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Julio0030
{
    
    public partial class Form1 : Form
    {
        double P1, P2, P3, P4, P5, P6;
        double MdN, SdN, MN, mN;
        string aprovacao;

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            LeiturasDeDados();
            Calculo obj_calculo = new Calculo(P1, P2, P3, P4, P5, P6);
            txt_MediasNotas.Text = Math.Round(MdN = obj_calculo.MediasDasNotas(), 2).ToString();
            txt_SomatorioNotas.Text = Math.Round(obj_calculo.SomatorioDasNotas(), 2).ToString();
            txt_MaiorNota.Text = (MN = obj_calculo.MaiorNota()).ToString();
            txt_MenorNota.Text = (mN = obj_calculo.MenorNota()).ToString();
            teste();
            txt_StatusdeAprovacao.Text = aprovacao;        
            txt_Turma.Text = cbx_turma.Text;
            txt_Curso.Text = cbx_curso.Text;
            txt_Periodo.Text = cbx_periodo.Text;
            txtRa.Text = txt_RA.Text;
            txtNome.Text = txt_Nome.Text;
            btn_Fechar.BackColor = Color.Red;
            Btn_Limpar.BackColor = Color.Green;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_P1.Text = string.Empty;
            txt_P2.Text = string.Empty;
            txt_P3.Text = string.Empty;
            txt_P4.Text = string.Empty;
            txt_P5.Text = string.Empty;
            txt_P6.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtRa.Text = string.Empty;
            txt_Curso.Text = string.Empty;
            txt_MaiorNota.Text = string.Empty;
            txt_MediasNotas.Text = string.Empty;
            txt_MenorNota.Text = string.Empty;
            txt_Nome.Text = string.Empty;
            txt_Periodo.Text = string.Empty;
            txt_RA.Text = string.Empty;
            txt_SomatorioNotas.Text = string.Empty;
            txt_StatusdeAprovacao.Text = string.Empty;
            txt_Turma.Text = string.Empty;
            cbx_curso.Text = null;
            cbx_periodo.Text = null;
            cbx_turma.Text = null;
            Btn_Limpar.BackColor = Color.AntiqueWhite;
            btn_Fechar.BackColor = Color.AntiqueWhite;

        }

        public Form1()
        {
            InitializeComponent();
        }
        public void LeiturasDeDados()
        {
            try
            {
                P1 = Convert.ToDouble(txt_P1.Text.Trim());
                P2 = Convert.ToDouble(txt_P2.Text.Trim());
                P3 = Convert.ToDouble(txt_P3.Text.Trim());
                P4 = Convert.ToDouble(txt_P4.Text.Trim());
                P5 = Convert.ToDouble(txt_P5.Text.Trim());
                P6 = Convert.ToDouble(txt_P6.Text.Trim());
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro na Entrada dados!\n" + erro);
            }
        }
        public void teste()
        {
            if (MdN < 6)
            {
                aprovacao = "Recuperação";
            }

            if (MdN > 6 && MdN < 7.999)
            {
                aprovacao = "Aprovado";
            }

            if (MdN >= 8)
            {
                aprovacao = "Aprovado Mérito";
            }
        }
    }
}
