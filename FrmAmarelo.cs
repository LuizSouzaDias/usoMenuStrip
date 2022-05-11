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
    public partial class FrmAmarelo : Form
    {
        public FrmAmarelo()
        {
            InitializeComponent();
        }

        private void exibirFormVermelho_Click(object sender, EventArgs e)
        {
            FrmVermelho vermelho = new FrmVermelho();    //instancio o form/indico qual quero abrir
            this.Hide();                             //fechar a aba atual
            vermelho.ShowDialog();                     // mostrar o forms na tela  
        }

        private void exibirFormAzul_Click(object sender, EventArgs e)
        {
            FrmAzul azul = new FrmAzul();    //instancio o form/indico qual quero abrir
            this.Hide();                             //fechar/esconder a aba atual
            azul.ShowDialog();                     // mostrar o forms na tela  
        }
    }
}
