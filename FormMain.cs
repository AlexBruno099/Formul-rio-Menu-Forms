using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formulario
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSegunda_Click(object sender, EventArgs e)
        {
            this.Hide(); // esconde a form principal
            FormSegunda f = new FormSegunda("Bem Vindo.");
            //f.Mensagem = "Alex";
            //f.Show(); // abre quantas forms quiser
            f.ShowDialog(); // abre somente uma e não consegue utilizar a principal
            if(f.Mensagem != null)
            {
                lblTitulo.Text = f.Mensagem;
            }
            this.Show(); // quando tu fecha a form segundaria a principal reaparece 
        }

        private void btnSegundaFormThread_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread t = new Thread(() => Application.Run(new FormSegunda()));
            t.Start();
        }

        private void mFileNovo_Click(object sender, EventArgs e)
        {
            new Thread(() => Application.Run(new FormMain())).Start();
        }

        private void mFileAbrir_Click(object sender, EventArgs e)
        {
            Hide();
            FormSegunda f = new FormSegunda();
            f.ShowDialog();
            Show();
        }

        private void mFileSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mHelpSobreDes_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Alex Bruno", "Desenvolvedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            
        }

        private void mHelpSobreVersao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Versão 1.0", "Versão", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }

        private void ComboMenu_Click(object sender, EventArgs e)
        {

        }

        private void ComboMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboMenu.SelectedIndex == 0)
            {
                menuFile.Text = "File";
                menuHelp.Text = "Help";
            } else 
            {
                menuFile.Text = "Arquivo";
                menuHelp.Text = "Ajuda";
            }
        }

        private void mPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                lblTitulo.Text = mPesquisar.Text;
                mPesquisar.Text = " ";
            }
        }
    }
}
