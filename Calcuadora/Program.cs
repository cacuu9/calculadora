using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcuadora
{
    static class Program
    {
        public static Principal frmPrincipal;
        public static ADODB.Connection cn = new ADODB.Connection();
        public static void DoyPermisos(string usuario){
            String sql;  byte rol = 0;
            ADODB.Recordset rs ;
            object filasAfectadas;
            frmPrincipal.menuAplicaciones.Enabled = false;
            frmPrincipal.menuClientes.Enabled = false;
            frmPrincipal.menuProveedores.Enabled = false;
            if (cn.State != 0) {
                sql = "Select rol from usuario_rol where usuario= " + usuario + ",";
                try {
                    rs = cn.Execute(sql, out filasAfectadas);
                } catch {
                    MessageBox.Show("Error al buscar rol del usuario.Si el problema persdiste, consulte al administrador");
                    return;
                }
                if (rs.RecordCount == 0) {
                    MessageBox.Show("No se encontro el rol del usuario.Comuniquese con el administrador");
                } else {
                    rol = Convert.ToByte (rs.Fields [0].Value);
                    switch (rol) {
                        case 1:
                            frmPrincipal.menuAplicaciones.Enabled = true;
                            frmPrincipal.menuProveedores.Enabled = true;
                            break;
                        case 2:
                            frmPrincipal.menuAplicaciones.Enabled = true;
                            frmPrincipal.menuClientes.Enabled = true;
                            break;
                    }
                }
                frmPrincipal.menuLogin.Text = "Logaut";
                rs = null;
                filasAfectadas = null;
            }
}
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(frmPrincipal = new Principal()); //de esta forma al instanciar el frmPrincipal podemos habilitar la ocultacion o visualizacion de los botones de menustrip.
        }
    }
}
