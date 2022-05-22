
namespace Formularios
{
    partial class ControlStock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFullStock = new System.Windows.Forms.Button();
            this.dgvTablaProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarNuevoProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFullStock
            // 
            this.btnFullStock.Location = new System.Drawing.Point(750, 54);
            this.btnFullStock.Name = "btnFullStock";
            this.btnFullStock.Size = new System.Drawing.Size(102, 31);
            this.btnFullStock.TabIndex = 1;
            this.btnFullStock.Text = "Full Stock";
            this.btnFullStock.UseVisualStyleBackColor = true;
            this.btnFullStock.Click += new System.EventHandler(this.btnFullStock_Click);
            // 
            // dgvTablaProductos
            // 
            this.dgvTablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTablaProductos.Location = new System.Drawing.Point(49, 54);
            this.dgvTablaProductos.Name = "dgvTablaProductos";
            this.dgvTablaProductos.RowHeadersWidth = 62;
            this.dgvTablaProductos.RowTemplate.Height = 25;
            this.dgvTablaProductos.Size = new System.Drawing.Size(683, 285);
            this.dgvTablaProductos.TabIndex = 3;
            // 
            // btnAgregarNuevoProducto
            // 
            this.btnAgregarNuevoProducto.Location = new System.Drawing.Point(288, 369);
            this.btnAgregarNuevoProducto.Name = "btnAgregarNuevoProducto";
            this.btnAgregarNuevoProducto.Size = new System.Drawing.Size(227, 40);
            this.btnAgregarNuevoProducto.TabIndex = 2;
            this.btnAgregarNuevoProducto.Text = "Agregar nuevo producto";
            this.btnAgregarNuevoProducto.UseVisualStyleBackColor = true;
            this.btnAgregarNuevoProducto.Click += new System.EventHandler(this.btnAgregarNuevoProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(577, 369);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(201, 40);
            this.btnEliminarProducto.TabIndex = 4;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
         
            // 
            // ControlStock
            // 
            this.ClientSize = new System.Drawing.Size(864, 456);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.dgvTablaProductos);
            this.Controls.Add(this.btnAgregarNuevoProducto);
            this.Controls.Add(this.btnFullStock);
            this.Name = "ControlStock";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.ControlStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFullStock;
        private System.Windows.Forms.DataGridView dgvTablaProductos;
        private System.Windows.Forms.Button btnAgregarNuevoProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
    }
}