using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using teladelogin.Apresentacao;

namespace teladelogin
{
    public partial class BemVindo : Form
    {
        public BemVindo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProdutos fProduto = new FrmProdutos();
            fProduto.Show();
                
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmProdutos Outroform = new FrmProdutos();
                Outroform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmFuncionarios Outroform = new FrmFuncionarios();
                 Outroform.ShowDialog();
        }
    }
}
