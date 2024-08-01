using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tela_facil
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        #region idioma
        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedIndex == 0)
            {
                FerramentasMenu.Text = "Tools";
                BlocoDeNotasFerramentasMenu.Text = "Notepade";
                CalculadoraFerramentasMenu.Text = "Calculation";
                ArquivosFerramentasMenu.Text = "My Files";
                DocumentosMenu.Text = "Documents";
                PlanilhasMenu.Text = "Spreadsheets";
                NavegadoresMenu.Text = "Browser";
                NoticiasMenu.Text = "News";
                SobreMenu.Text = "About";
                AjudaMenu.Text = "Help";
                label1.Text = "Easy Screen - making your day easier";
                btnSair.Text = "Exit";
            }
            else
            {
                FerramentasMenu.Text = "Ferramentas";
                BlocoDeNotasFerramentasMenu.Text = "Bloco de Notas";
                CalculadoraFerramentasMenu.Text = "Calculadora";
                DocumentosMenu.Text = "Documentos";
                PlanilhasMenu.Text = "Planilhas";
                NavegadoresMenu.Text = "Navegadores";
                NoticiasMenu.Text = "Notícias";
                SobreMenu.Text = "Sobre";
                AjudaMenu.Text = "Ajuda";
                label1.Text = "Tela Fácil - Facilitando o seu dia";
                btnSair.Text = "Sair";
            }
        }
        #endregion

        #region ferramentas
        
        

       

       
        private void ArquivosFerramentasMenu_Click(object sender, EventArgs e)
        {   //explorador de arquivos
            Process.Start("explorer");
        }

        private void BlocoDeNotasFerramentasMenu_Click_1(object sender, EventArgs e)
        {   //bloco de notas 
            Process.Start("notepad");
        }

        private void CalculadoraFerramentasMenu_Click_1(object sender, EventArgs e)
        {
            //calculadora
            Process.Start("calc.exe");
        }
        private void DOSFerramentasMenu_Click(object sender, EventArgs e)
        {   //dos
            Process.Start("cmd.exe");
        }
        #endregion


        #region planilha

        

        private void Planilha1PlanilhasMenu_Click(object sender, EventArgs e)
        {
            //Planilha dimob
            Process.Start("excel.exe", @"l:\Patricia\DIMOB_RELATORIO_RECEBIMENTO_ALUGUEIS_DIMOB_1");
        }

        private void Planilha2PlanilhasMenu_Click(object sender, EventArgs e)
        {
            //Planilha distribuição lucros
            Process.Start("excel.exe", @"l:\Patricia\DISTRIBUICAO_DE_LUCRO_2023");
        }

        private void Planilha3PlanilhasMenu_Click(object sender, EventArgs e)
        {
            //Planilha obra de barra mansa
            Process.Start("excel.exe", @"l:\Patricia\OBRA_BARRA_MANSA(724)");
        }

        private void Planilha4PlanilhasMenu_Click(object sender, EventArgs e)
        {
            //Planilha obra da ilha
            Process.Start("excel.exe", @"l:\Patricia\OBRA_ILHA_FELIPE");
        }
        private void Planilha5PlanilhasMenu_Click(object sender, EventArgs e)
        {
            //Planilha diaria fazenda
            Process.Start("excel.exe", @"l:\Patricia\PLANILHA_DIARIA_FAZENDA");
        }

        private void ImoveisALPPlanilhasMenu_Click(object sender, EventArgs e)
        {
            //Planilha imoveis da alp
            Process.Start("excel.exe", @"l:\Patricia\PLANILHA_IMOVEIS_ALP_PARTTICIPACOES");
        }

        #endregion

    }
}
