using System;
using System.Windows.Forms;
using System.Data;
using PEDROCORDEIRO3A1.Code.BLL;
using PEDROCORDEIRO3A1.Code.DTO;

namespace PEDROCORDEIRO3A1.Ui
{
    public partial class Games : Form
    {
        GameDTO DTO = new GameDTO();
        GameBLL BLL = new GameBLL();
        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e){
            dadosGames.DataSource = BLL.Read();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            DTO.Nome = txt_nome.Text;
            DTO.Genero = txt_genero.Text;
            DTO.Valor = double.Parse(txt_valor.Text);
            BLL.Insert(DTO);
            MessageBox.Show("Cadastro realizado!");
            dadosGames.DataSource = BLL.Read();
            txt_nome.Clear();
            txt_genero.Clear();
            txt_valor.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DTO.Codigo = int.Parse(txt_codigo.Text);
            BLL.Delete(DTO);
            MessageBox.Show("Cadastro excluído!");
            dadosGames.DataSource = BLL.Read();
            txt_nome.Clear();
            txt_genero.Clear();
            txt_valor.Clear();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dadosGames.DataSource = BLL.Read();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            DTO.Codigo = int.Parse(txt_codigo.Text);
            DTO.Nome = txt_nome.Text;
            DTO.Genero = txt_genero.Text;
            DTO.Valor = double.Parse(txt_valor.Text);
            BLL.Update(DTO);
            MessageBox.Show("Cadastro alterado!");
            dadosGames.DataSource = BLL.Read();
            txt_codigo.Clear();
            txt_nome.Clear();
            txt_genero.Clear();
            txt_valor.Clear();
        }

        private void dadosGames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_codigo.Text = dadosGames.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dadosGames.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_genero.Text = dadosGames.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_valor.Text = dadosGames.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
