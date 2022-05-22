using Logica;
using System;
using System.Windows.Forms;

namespace Formularios
{
    public partial class frmAltaProducto : Form
    {


        private Producto productoCreado;


        public frmAltaProducto()
        {
            InitializeComponent();
        }

        public Producto GetProductoCreado
        {
            get
            {
                return productoCreado;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.txtNombreProducto.Text;
            int.TryParse(txtCodigoProducto.Text, out int codProducto);
            float.TryParse(txtValorVenta.Text, out float valorVenta);
            int.TryParse(txtCantidadStock.Text, out int stock);
            ETipo tipoAlimento;
            if (rbtnComestible.Checked == true)
            {
                tipoAlimento = ETipo.comestible;
            }
            else
            {
                tipoAlimento = ETipo.bebible;
            }

            productoCreado = new Producto(nombre, valorVenta, stock, tipoAlimento);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
