using Logica;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class GestionDeEmpleados : Form
    {



        public GestionDeEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
        }

        private void btnAgregarNuevoEmpleado_Click(object sender, EventArgs e)
        {
            AltaEmpleado formAltaEmpleado = new AltaEmpleado();
            if (formAltaEmpleado.ShowDialog() == DialogResult.OK)
            {
                Bar.AgregarEmpleadoALaLista(formAltaEmpleado.GetNuevoEmpleado);
                ActualizarListBox();
                MessageBox.Show("carga exitosa");

            }
        }


        private void ActualizarListBox()
        {
            dgvTablaEmpleados.DataSource = null;
            dgvTablaEmpleados.DataSource = Bar.ListarSegunTipo(2);
        }



    }
}
