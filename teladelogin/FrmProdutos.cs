using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace teladelogin
{
    public partial class FrmProdutos : Form
    {
        SqlConnection conexao;
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
          
            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {


            DialogResult resultado = MessageBox.Show("Deseja excluir?", "Atenção", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (resultado == DialogResult.OK)
            {
                //String de conexão com o banco de dados
                string strConexao = @"Server=ORGANICFARM\SQLEXPRESS;
 Database=BD_Fazenda_Urbana;Integrated Security = True";
                string cmdDelete =
                 "DELETE produto where codbar_prod=" + txtcodBarras.Text;
                SqlConnection con = new SqlConnection(strConexao);
                SqlCommand sqlCommand = new SqlCommand(cmdDelete, con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Dados excluidos com sucesso!");
                btnLimpar.PerformClick();
                con.Close();
                /*int codProd = 0;
                //recuperar o id(matricula) do Form(textBox)
                codProd = Convert.ToInt32(txtMatricula.Text);
                MessageBox.Show("excluir...");
                //criar uma conexao
                conexao = clnConexao.getConexao();
                Produto prod = new Produto();
         
                //criar um objeto ProdutoDAL 
                ProdutoDAL prodDal = new ProdutoDAL();

                //e executar a inserção
                try
                {
                    //abrir a conexao
                    prodDal.abrirConexao(conexao);
                    //executar o delete
                    prodDal.DelProd(conexao, prod);

                    MessageBox.Show("Dados excluidos com sucesso!");
                    btnLimpar.PerformClick();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex.Message);
                }
            }*/
            }
            else
            {
                MessageBox.Show("Cancelar...");

            }


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtcodBarras.Clear();
            cmbMarca.SelectedIndex = -1;
            cmbMedida.SelectedIndex = -1;
            txtPreco.Clear();
            txtQuant.Clear();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void cmbMedida_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }
    }
}
