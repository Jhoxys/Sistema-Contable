namespace SistemaVentas.Presentacion
{
	partial class frmProductos
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
            System.Windows.Forms.Label Dzx;
            this.btnBuscarCategoria = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDecripcion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCategoriaId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.lblDatosNoEncontrados = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cmbBuscar = new System.Windows.Forms.ComboBox();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dvgdatoCliente = new System.Windows.Forms.GroupBox();
            this.txtFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.Imagen = new System.Windows.Forms.PictureBox();
            this.textCategoriaDescripcion = new System.Windows.Forms.TextBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textPrecioVenta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dvgCliente = new System.Windows.Forms.GroupBox();
            this.dialogo = new System.Windows.Forms.OpenFileDialog();
            this.txtFlag = new System.Windows.Forms.TextBox();
            Dzx = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.dvgdatoCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).BeginInit();
            this.dvgCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dzx
            // 
            Dzx.AutoSize = true;
            Dzx.Location = new System.Drawing.Point(6, 185);
            Dzx.Name = "Dzx";
            Dzx.Size = new System.Drawing.Size(83, 15);
            Dzx.TabIndex = 0;
            Dzx.Text = "Descripcion";
            // 
            // btnBuscarCategoria
            // 
            this.btnBuscarCategoria.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscarCategoria.Location = new System.Drawing.Point(512, 86);
            this.btnBuscarCategoria.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnBuscarCategoria.Name = "btnBuscarCategoria";
            this.btnBuscarCategoria.Size = new System.Drawing.Size(36, 30);
            this.btnBuscarCategoria.TabIndex = 2;
            this.btnBuscarCategoria.Text = "...";
            this.btnBuscarCategoria.UseVisualStyleBackColor = false;
            this.btnBuscarCategoria.Click += new System.EventHandler(this.btnBuscarCategoria_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(80, 571);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditar.Location = new System.Drawing.Point(204, 613);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 35);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(80, 613);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(84, 35);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(152, 279);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(353, 21);
            this.txtPrecioCompra.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Precio Compra";
            // 
            // textStock
            // 
            this.textStock.Location = new System.Drawing.Point(152, 233);
            this.textStock.Name = "textStock";
            this.textStock.Size = new System.Drawing.Size(353, 21);
            this.textStock.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Stock";
            // 
            // txtDecripcion
            // 
            this.txtDecripcion.Location = new System.Drawing.Point(152, 186);
            this.txtDecripcion.Name = "txtDecripcion";
            this.txtDecripcion.Size = new System.Drawing.Size(353, 21);
            this.txtDecripcion.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(152, 139);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(353, 21);
            this.txtNombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // txtCategoriaId
            // 
            this.txtCategoriaId.Location = new System.Drawing.Point(152, 92);
            this.txtCategoriaId.Name = "txtCategoriaId";
            this.txtCategoriaId.Size = new System.Drawing.Size(53, 21);
            this.txtCategoriaId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Categoria";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(152, 55);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(353, 21);
            this.txtId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnEliminar.Location = new System.Drawing.Point(27, 605);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 30);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // lblDatosNoEncontrados
            // 
            this.lblDatosNoEncontrados.AutoSize = true;
            this.lblDatosNoEncontrados.Location = new System.Drawing.Point(181, 279);
            this.lblDatosNoEncontrados.Name = "lblDatosNoEncontrados";
            this.lblDatosNoEncontrados.Size = new System.Drawing.Size(166, 15);
            this.lblDatosNoEncontrados.TabIndex = 3;
            this.lblDatosNoEncontrados.Text = "No se encontraron Datos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(192, 28);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(362, 21);
            this.txtBuscar.TabIndex = 2;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.FormattingEnabled = true;
            this.cmbBuscar.Items.AddRange(new object[] {
            "Nombre",
            "Descripcion",
            "Stock",
            "PrecioCompra",
            "PrecioVenta",
            "Fechavencimiento"});
            this.cmbBuscar.Location = new System.Drawing.Point(27, 28);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(121, 23);
            this.cmbBuscar.TabIndex = 1;
            this.cmbBuscar.Text = "Nombre";
            // 
            // dgvProducto
            // 
            this.dgvProducto.AllowUserToAddRows = false;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dgvProducto.Location = new System.Drawing.Point(27, 57);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.ReadOnly = true;
            this.dgvProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducto.Size = new System.Drawing.Size(657, 542);
            this.dgvProducto.TabIndex = 0;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            this.dgvProducto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellDoubleClick);
            // 
            // dvgdatoCliente
            // 
            this.dvgdatoCliente.Controls.Add(this.txtFechaVencimiento);
            this.dvgdatoCliente.Controls.Add(this.Imagen);
            this.dvgdatoCliente.Controls.Add(this.textCategoriaDescripcion);
            this.dvgdatoCliente.Controls.Add(this.btnCambiar);
            this.dvgdatoCliente.Controls.Add(this.btnQuitar);
            this.dvgdatoCliente.Controls.Add(this.btnBuscarCategoria);
            this.dvgdatoCliente.Controls.Add(this.btnCancelar);
            this.dvgdatoCliente.Controls.Add(this.btnGuardar);
            this.dvgdatoCliente.Controls.Add(this.btnEditar);
            this.dvgdatoCliente.Controls.Add(this.btnNuevo);
            this.dvgdatoCliente.Controls.Add(this.label7);
            this.dvgdatoCliente.Controls.Add(this.textPrecioVenta);
            this.dvgdatoCliente.Controls.Add(this.label4);
            this.dvgdatoCliente.Controls.Add(this.txtPrecioCompra);
            this.dvgdatoCliente.Controls.Add(this.label6);
            this.dvgdatoCliente.Controls.Add(this.textStock);
            this.dvgdatoCliente.Controls.Add(this.label5);
            this.dvgdatoCliente.Controls.Add(this.txtDecripcion);
            this.dvgdatoCliente.Controls.Add(Dzx);
            this.dvgdatoCliente.Controls.Add(this.txtNombre);
            this.dvgdatoCliente.Controls.Add(this.label3);
            this.dvgdatoCliente.Controls.Add(this.txtCategoriaId);
            this.dvgdatoCliente.Controls.Add(this.label2);
            this.dvgdatoCliente.Controls.Add(this.txtId);
            this.dvgdatoCliente.Controls.Add(this.label1);
            this.dvgdatoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgdatoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgdatoCliente.Location = new System.Drawing.Point(13, 39);
            this.dvgdatoCliente.Name = "dvgdatoCliente";
            this.dvgdatoCliente.Size = new System.Drawing.Size(559, 668);
            this.dvgdatoCliente.TabIndex = 3;
            this.dvgdatoCliente.TabStop = false;
            this.dvgdatoCliente.Text = "Datos de Producto";
            // 
            // txtFechaVencimiento
            // 
            this.txtFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFechaVencimiento.Location = new System.Drawing.Point(172, 361);
            this.txtFechaVencimiento.Name = "txtFechaVencimiento";
            this.txtFechaVencimiento.Size = new System.Drawing.Size(333, 21);
            this.txtFechaVencimiento.TabIndex = 5;
            // 
            // Imagen
            // 
            this.Imagen.BackgroundImage = global::SistemaVentas.Properties.Resources._56296;
            this.Imagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Imagen.Location = new System.Drawing.Point(6, 409);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(254, 156);
            this.Imagen.TabIndex = 4;
            this.Imagen.TabStop = false;
            // 
            // textCategoriaDescripcion
            // 
            this.textCategoriaDescripcion.Location = new System.Drawing.Point(211, 92);
            this.textCategoriaDescripcion.Name = "textCategoriaDescripcion";
            this.textCategoriaDescripcion.Size = new System.Drawing.Size(294, 21);
            this.textCategoriaDescripcion.TabIndex = 3;
            // 
            // btnCambiar
            // 
            this.btnCambiar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCambiar.Location = new System.Drawing.Point(281, 421);
            this.btnCambiar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(237, 36);
            this.btnCambiar.TabIndex = 2;
            this.btnCambiar.Text = "Cambiar  Imagen";
            this.btnCambiar.UseVisualStyleBackColor = false;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnQuitar.Location = new System.Drawing.Point(281, 475);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(224, 36);
            this.btnQuitar.TabIndex = 2;
            this.btnQuitar.Text = "Quitar Imagen";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(197, 571);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fecha de Vencimiento";
            // 
            // textPrecioVenta
            // 
            this.textPrecioVenta.Location = new System.Drawing.Point(152, 321);
            this.textPrecioVenta.Name = "textPrecioVenta";
            this.textPrecioVenta.Size = new System.Drawing.Size(353, 21);
            this.textPrecioVenta.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio Venta";
            // 
            // dvgCliente
            // 
            this.dvgCliente.Controls.Add(this.BtnEliminar);
            this.dvgCliente.Controls.Add(this.lblDatosNoEncontrados);
            this.dvgCliente.Controls.Add(this.txtBuscar);
            this.dvgCliente.Controls.Add(this.cmbBuscar);
            this.dvgCliente.Controls.Add(this.dgvProducto);
            this.dvgCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dvgCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dvgCliente.Location = new System.Drawing.Point(567, 39);
            this.dvgCliente.Name = "dvgCliente";
            this.dvgCliente.Size = new System.Drawing.Size(660, 651);
            this.dvgCliente.TabIndex = 2;
            this.dvgCliente.TabStop = false;
            this.dvgCliente.Text = "Listado de Producto";
            // 
            // dialogo
            // 
            this.dialogo.FileName = "openFileDialog1";
            // 
            // txtFlag
            // 
            this.txtFlag.Location = new System.Drawing.Point(508, 2);
            this.txtFlag.Name = "txtFlag";
            this.txtFlag.Size = new System.Drawing.Size(53, 20);
            this.txtFlag.TabIndex = 6;
            this.txtFlag.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFlag.Visible = false;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 743);
            this.Controls.Add(this.txtFlag);
            this.Controls.Add(this.dvgdatoCliente);
            this.Controls.Add(this.dvgCliente);
            this.Name = "frmProductos";
            this.Text = "Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.dvgdatoCliente.ResumeLayout(false);
            this.dvgdatoCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Imagen)).EndInit();
            this.dvgCliente.ResumeLayout(false);
            this.dvgCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBuscarCategoria;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.TextBox txtPrecioCompra;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textStock;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtDecripcion;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCategoriaId;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Label lblDatosNoEncontrados;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.ComboBox cmbBuscar;
		private System.Windows.Forms.DataGridView dgvProducto;
		private System.Windows.Forms.GroupBox dvgdatoCliente;
		private System.Windows.Forms.GroupBox dvgCliente;
		private System.Windows.Forms.TextBox textCategoriaDescripcion;
		private System.Windows.Forms.TextBox textPrecioVenta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.PictureBox Imagen;
		private System.Windows.Forms.Button btnCambiar;
		private System.Windows.Forms.DateTimePicker txtFechaVencimiento;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.OpenFileDialog dialogo;
        private System.Windows.Forms.TextBox txtFlag;
    }
}