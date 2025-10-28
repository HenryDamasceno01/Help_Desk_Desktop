using HelpDesk.Business;
using System.Windows.Forms;

namespace Help_Desk_Desktop
{
    // A classe deve ser 'public partial' e HERDAR de 'Form'
    public partial class LoginForm : Form
    {
        // Declara o serviço de login (precisa estar na classe principal)
        private readonly LoginService _loginService = new LoginService();
        private Usuario usuarioLogado;

        // Define a propriedade para retornar o usuário logado (com o tipo correto)
        public Usuario GetUsuarioLogado()
        {
            return usuarioLogado;
        }

        private void SetUsuarioLogado(Usuario value)
        {
            usuarioLogado=value;
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // LoginForm
            // 
            ClientSize = new System.Drawing.Size(401, 311);
            Name = "LoginForm";
            ResumeLayout(false);

        }

        public LoginForm()
        {
            // Este método é essencial e é criado pelo designer
            InitializeComponent();
        }


    }
}