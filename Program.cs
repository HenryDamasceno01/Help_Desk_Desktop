using System;
using System.Windows.Forms;
using HelpDesk.Business;

namespace Help_Desk_Desktop
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Lógica de Login:
            using LoginForm loginForm = new();
            // Tenta fazer o login
            if (loginForm.ShowDialog() == DialogResult.OK)
            {
                // Se o resultado for OK, inicia a tela principal com o usuário logado
                Application.Run(new FormPrincipal(loginForm.GetUsuarioLogado()));
            }
            // Se o usuário fechar a tela de login ou o login falhar, o aplicativo termina aqui.

        }

        private class FormPrincipal : Form
        {
            private object usuarioLogado;

            public FormPrincipal(object usuarioLogado)
            {
                this.usuarioLogado=usuarioLogado;
            }
        }
    }
}