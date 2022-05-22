using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Formularios;
using Logica;

namespace UI
{
    public partial class FormLoguin : Form
    {

        public static class VariablesCompartidas
        {
            private static bool tipoUsuario;
            public static bool TipoUsuario { get => tipoUsuario; set => tipoUsuario = value; }

            private static int numeroMesa;

            public static int NumeroMesa { get => numeroMesa; set => numeroMesa = value; }
          
           
        }

        public FormLoguin()
        {
            InitializeComponent();
        }


        private void FormLoguin_Load(object sender, EventArgs e)
        {


        }



        private void btnRellenar_Click(object sender, EventArgs e)
        {
            this.txbPassword.Text = "admi";
            this.txbUsuario.Text = "eze";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txbUsuario.Text;
            string pass = this.txbPassword.Text;


            if (Usuarios.LogueoDeUsuario(usuario, pass))
            {
                Usuarios usuarioLogueado = Usuarios.GuardarUsuario(usuario, pass);
                VariablesCompartidas.TipoUsuario = Usuarios.TipoUsuario(Usuarios.GuardarUsuario(usuario, pass));

                frmMenuPrincipal menu = new frmMenuPrincipal();
                menu.Show();

                DialogResult res = MessageBox.Show($"{usuarioLogueado.MostrarInfo()}", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (res == DialogResult.OK)
                {
                    this.Visible = false;
                }

            }
            else
            {
                MessageBox.Show("Usuario/Contraseña incorrecta verifique", "Error al registrar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void picBoxBotonApagado_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelleano_Click(object sender, EventArgs e)
        {
            this.txbPassword.Text = "admi";
            this.txbUsuario.Text = "lucas";
        }
    }
}
