using Logica;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class AltaEmpleado : Form
    {

        private Empleado nuevoEmpleado;


        public Empleado GetNuevoEmpleado
        {
            get
            { return nuevoEmpleado; }
        }

        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {

            string nombre = this.txtNombre.Text;
            int.TryParse(this.txtDni.Text, out int dni);
            string pass = this.txtPassword.Text;


            nuevoEmpleado = new Empleado(dni, nombre, pass, false);
            this.DialogResult = DialogResult.OK;
        }





    }
}
