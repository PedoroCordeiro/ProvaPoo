using System;
using System.Windows.Forms;
using PEDROCORDEIRO3A1.Code.BLL;
using PEDROCORDEIRO3A1.Code.DTO;

namespace PEDROCORDEIRO3A1.Ui
{
    public partial class Login : Form
    {
        LoginDTO DTO = new LoginDTO();
        LoginBLL BLL = new LoginBLL();
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e){
            DTO.Email = txt_email.Text;
            DTO.Senha = txt_senha.Text;
            if (BLL.Logar(DTO) == true)
            {
                Games abrir = new Games();
                abrir.ShowDialog();
            }
            else{
                MessageBox.Show("Alguma informação está incorreta");
            }
        }
    }
}
