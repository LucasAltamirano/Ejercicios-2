
namespace UI
{
    partial class frmInformacionMesa
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblOrientativoValor = new System.Windows.Forms.Label();
            this.lblIndicativoCant = new System.Windows.Forms.Label();
            this.lblIndicativoProductosDisponibles = new System.Windows.Forms.Label();
            this.checkUsoEstacionamiento = new System.Windows.Forms.CheckBox();
            this.checkPagoConTarjeta = new System.Windows.Forms.CheckBox();
            this.lblTotalConsumido = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lstBoxPedidosCargados = new System.Windows.Forms.ListBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.lblReferenciaValor = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblMesasOrientativo = new System.Windows.Forms.Label();
            this.lblNumMesaOrientativo = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCerrarMesa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 590);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 79;
            this.label1.Text = "Total $";
            // 
            // lblOrientativoValor
            // 
            this.lblOrientativoValor.AutoSize = true;
            this.lblOrientativoValor.Location = new System.Drawing.Point(496, 93);
            this.lblOrientativoValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrientativoValor.Name = "lblOrientativoValor";
            this.lblOrientativoValor.Size = new System.Drawing.Size(52, 25);
            this.lblOrientativoValor.TabIndex = 78;
            this.lblOrientativoValor.Text = "Valor";
            // 
            // lblIndicativoCant
            // 
            this.lblIndicativoCant.AutoSize = true;
            this.lblIndicativoCant.Location = new System.Drawing.Point(343, 93);
            this.lblIndicativoCant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicativoCant.Name = "lblIndicativoCant";
            this.lblIndicativoCant.Size = new System.Drawing.Size(83, 25);
            this.lblIndicativoCant.TabIndex = 77;
            this.lblIndicativoCant.Text = "Cantidad";
            // 
            // lblIndicativoProductosDisponibles
            // 
            this.lblIndicativoProductosDisponibles.AutoSize = true;
            this.lblIndicativoProductosDisponibles.Location = new System.Drawing.Point(123, 93);
            this.lblIndicativoProductosDisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIndicativoProductosDisponibles.Name = "lblIndicativoProductosDisponibles";
            this.lblIndicativoProductosDisponibles.Size = new System.Drawing.Size(191, 25);
            this.lblIndicativoProductosDisponibles.TabIndex = 76;
            this.lblIndicativoProductosDisponibles.Text = "Productos Disponibles";
            // 
            // checkUsoEstacionamiento
            // 
            this.checkUsoEstacionamiento.AutoSize = true;
            this.checkUsoEstacionamiento.BackColor = System.Drawing.Color.Transparent;
            this.checkUsoEstacionamiento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkUsoEstacionamiento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkUsoEstacionamiento.Location = new System.Drawing.Point(410, 357);
            this.checkUsoEstacionamiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkUsoEstacionamiento.Name = "checkUsoEstacionamiento";
            this.checkUsoEstacionamiento.Size = new System.Drawing.Size(265, 32);
            this.checkUsoEstacionamiento.TabIndex = 75;
            this.checkUsoEstacionamiento.Text = "Uso de Estacionamiento";
            this.checkUsoEstacionamiento.UseVisualStyleBackColor = false;
            // 
            // checkPagoConTarjeta
            // 
            this.checkPagoConTarjeta.AutoSize = true;
            this.checkPagoConTarjeta.BackColor = System.Drawing.Color.Transparent;
            this.checkPagoConTarjeta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkPagoConTarjeta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkPagoConTarjeta.Location = new System.Drawing.Point(410, 402);
            this.checkPagoConTarjeta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkPagoConTarjeta.Name = "checkPagoConTarjeta";
            this.checkPagoConTarjeta.Size = new System.Drawing.Size(261, 32);
            this.checkPagoConTarjeta.TabIndex = 74;
            this.checkPagoConTarjeta.Text = "Pago con tarjeta  +10%";
            this.checkPagoConTarjeta.UseVisualStyleBackColor = false;
            // 
            // lblTotalConsumido
            // 
            this.lblTotalConsumido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTotalConsumido.Location = new System.Drawing.Point(457, 625);
            this.lblTotalConsumido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalConsumido.Name = "lblTotalConsumido";
            this.lblTotalConsumido.Size = new System.Drawing.Size(130, 40);
            this.lblTotalConsumido.TabIndex = 73;
            this.lblTotalConsumido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(299, 180);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(190, 38);
            this.btnAgregar.TabIndex = 72;
            this.btnAgregar.Text = "Agregar a la mesa";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lstBoxPedidosCargados
            // 
            this.lstBoxPedidosCargados.FormattingEnabled = true;
            this.lstBoxPedidosCargados.ItemHeight = 25;
            this.lstBoxPedidosCargados.Location = new System.Drawing.Point(136, 240);
            this.lstBoxPedidosCargados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstBoxPedidosCargados.Name = "lstBoxPedidosCargados";
            this.lstBoxPedidosCargados.Size = new System.Drawing.Size(267, 454);
            this.lstBoxPedidosCargados.TabIndex = 71;
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbCantidad.Location = new System.Drawing.Point(343, 123);
            this.cmbCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(97, 33);
            this.cmbCantidad.TabIndex = 70;
            this.cmbCantidad.SelectedValueChanged += new System.EventHandler(this.cmbCantidad_SelectedValueChanged);
            // 
            // lblReferenciaValor
            // 
            this.lblReferenciaValor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReferenciaValor.Location = new System.Drawing.Point(496, 123);
            this.lblReferenciaValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReferenciaValor.Name = "lblReferenciaValor";
            this.lblReferenciaValor.Size = new System.Drawing.Size(130, 40);
            this.lblReferenciaValor.TabIndex = 69;
            this.lblReferenciaValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(123, 123);
            this.cmbProductos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(171, 33);
            this.cmbProductos.TabIndex = 68;
            this.cmbProductos.SelectedValueChanged += new System.EventHandler(this.cmbProductos_SelectedValueChanged);
            // 
            // lblMesasOrientativo
            // 
            this.lblMesasOrientativo.AutoSize = true;
            this.lblMesasOrientativo.Location = new System.Drawing.Point(106, 9);
            this.lblMesasOrientativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMesasOrientativo.Name = "lblMesasOrientativo";
            this.lblMesasOrientativo.Size = new System.Drawing.Size(170, 25);
            this.lblMesasOrientativo.TabIndex = 67;
            this.lblMesasOrientativo.Text = "Mesa Seleccionada :";
            // 
            // lblNumMesaOrientativo
            // 
            this.lblNumMesaOrientativo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumMesaOrientativo.Location = new System.Drawing.Point(293, 10);
            this.lblNumMesaOrientativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumMesaOrientativo.Name = "lblNumMesaOrientativo";
            this.lblNumMesaOrientativo.Size = new System.Drawing.Size(61, 40);
            this.lblNumMesaOrientativo.TabIndex = 80;
            this.lblNumMesaOrientativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(689, 505);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(190, 38);
            this.btnAceptar.TabIndex = 81;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCerrarMesa
            // 
            this.btnCerrarMesa.Location = new System.Drawing.Point(689, 577);
            this.btnCerrarMesa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCerrarMesa.Name = "btnCerrarMesa";
            this.btnCerrarMesa.Size = new System.Drawing.Size(190, 38);
            this.btnCerrarMesa.TabIndex = 82;
            this.btnCerrarMesa.Text = "Cerrar";
            this.btnCerrarMesa.UseVisualStyleBackColor = true;
            // 
            // frmInformacionMesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btnCerrarMesa);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblNumMesaOrientativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOrientativoValor);
            this.Controls.Add(this.lblIndicativoCant);
            this.Controls.Add(this.lblIndicativoProductosDisponibles);
            this.Controls.Add(this.checkUsoEstacionamiento);
            this.Controls.Add(this.checkPagoConTarjeta);
            this.Controls.Add(this.lblTotalConsumido);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstBoxPedidosCargados);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.lblReferenciaValor);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.lblMesasOrientativo);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmInformacionMesa";
            this.Text = "Mesa";
            this.Load += new System.EventHandler(this.frmInformacionMesa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOrientativoValor;
        private System.Windows.Forms.Label lblIndicativoCant;
        private System.Windows.Forms.Label lblIndicativoProductosDisponibles;
        private System.Windows.Forms.CheckBox checkUsoEstacionamiento;
        private System.Windows.Forms.CheckBox checkPagoConTarjeta;
        private System.Windows.Forms.Label lblTotalConsumido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox lstBoxPedidosCargados;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Label lblReferenciaValor;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.Label lblMesasOrientativo;
        private System.Windows.Forms.Label lblNumMesaOrientativo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCerrarMesa;
    }
}