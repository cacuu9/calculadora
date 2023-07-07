using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuadora
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                Program.cn.Open("miodbs",txtUsuario.Text, txtContrasenia.Text);
            }
            catch
            {
                MessageBox.Show("Usuario o contraseña erròneos");
                return;
            }
            Program.frmPrincipal.menuLogin.Text = "logout";
            Program.frmPrincipal.menuAplicaciones.Enabled = true;
            this.Close();
        }
    }
}
