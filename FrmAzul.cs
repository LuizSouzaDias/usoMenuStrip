using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppExemploMenu
{
    public partial class FrmAzul : Form
    {
        public FrmAzul()
        {
            InitializeComponent();
        }

        private void exibirFormVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho vermelho = new FrmVermelho();    //instancio o form/indico qual quero abrir
            this.Hide();                             //fechar a aba atual
            vermelho.ShowDialog();                     // mostrar o forms na tela  
        }

        private void exibirFormAmarelo_Click(object sender, EventArgs e)
        {
            FrmAmarelo amarelo = new FrmAmarelo();    //instancio o form/indico qual quero abrir
            this.Hide();                             //fechar a aba atual
            amarelo.ShowDialog();                     // mostrar o forms na tela  
        }
    }
}
