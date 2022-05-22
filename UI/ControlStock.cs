using Logica;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Formularios
{
    public partial class ControlStock : Form
    {
        const int maxStock = 150;

        public ControlStock()
        {
            InitializeComponent();
        }

        private void ControlStock_Load(object sender, EventArgs e)
        {
            ActualizarListBox();
        }
        private void btnAgregarNuevoProducto_Click(object sender, EventArgs e)
        {
            frmAltaProducto alta = new frmAltaProducto();

            if (alta.ShowDialog() == DialogResult.OK)
            {
                Bar.AgregarProductoALaLista(alta.GetProductoCreado);
                Producto pr = (alta.GetProductoCreado);
                Bar.AgreagarProducAlDiccionario(pr.IdProducto, pr.Nombre);
                ActualizarListBox();
            }
        }



        private void ActualizarListBox()
        {
            dgvTablaProductos.DataSource = null;
            dgvTablaProductos.DataSource = Bar.ListaProductos;
        }

        /// <summary>
        /// Al presionar el boton se llevara la cantidad de stock de todos los productos al maximo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFullStock_Click(object sender, EventArgs e)
        {

            

        }

        //private void btnEliminarProducto_Click(object sender, EventArgs e)
        //{
        //    int indice = dgvTablaProductos.CurrentRow.Index;
        //    dgvTablaProductos.Rows.RemoveAt(dgvTablaProductos.CurrentRow.Index);
        //    List<Productos> listaAux = Bar.ListaProductos;
                           
        //   listaAux.RemoveAt(indice);


        //}
    }
}
