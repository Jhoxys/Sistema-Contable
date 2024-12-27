namespace SistemaVentas.Presentacion
{
	partial class FrmCategoria
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
			this.dvgdatoCliente = new System.Windows.Forms.GroupBox();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnEditar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dvgCliente = new System.Windows.Forms.GroupBox();
			this.BtnEliminar = new System.Windows.Forms.Button();
			this.lblDatosNoEncontrados = new System.Windows.Forms.Label();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.cmbBuscar = new System.Windows.Forms.ComboBox();
			this.dgvCategoria = new System.Windows.Forms.DataGridView();
			this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.txtFlag = new System.Windows.Forms.TextBox();
			this.dvgdatoCliente.SuspendLayout();
			this.dvgCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
			this.SuspendLayout();
			// 
			// dvgdatoCliente
			// 
			this.dvgdatoCliente.Controls.Add(this.btnCancelar);
			this.dvgdatoCliente.Controls.Add(this.btnGuardar);
			this.dvgdatoCliente.Controls.Add(this.btnEditar);
			this.dvgdatoCliente.Controls.Add(this.btnNuevo);
			this.dvgdatoCliente.Controls.Add(this.txtNombre);
			this.dvgdatoCliente.Controls.Add(this.label2);
			this.dvgdatoCliente.Controls.Add(this.txtId);
			this.dvgdatoCliente.Controls.Add(this.label1);
			this.dvgdatoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dvgdatoCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.dvgdatoCliente.Location = new System.Drawing.Point(44, 43);
			this.dvgdatoCliente.Name = "dvgdatoCliente";
			this.dvgdatoCliente.Size = new System.Drawing.Size(490, 662);
			this.dvgdatoCliente.TabIndex = 3;
			this.dvgdatoCliente.TabStop = false;
			this.dvgdatoCliente.Text = "Datos de Categoria";
			// 
			// btnCancelar
			// 
			this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCancelar.Location = new System.Drawing.Point(251, 511);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(85, 36);
			this.btnCancelar.TabIndex = 2;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.UseVisualStyleBackColor = false;
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnGuardar.Location = new System.Drawing.Point(127, 511);
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
			this.btnEditar.Location = new System.Drawing.Point(251, 564);
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
			this.btnNuevo.Location = new System.Drawing.Point(127, 564);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(84, 35);
			this.btnNuevo.TabIndex = 2;
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(95, 96);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(358, 21);
			this.txtNombre.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 95);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(83, 15);
			this.label2.TabIndex = 0;
			this.label2.Text = "Descripcion";
			// 
			// txtId
			// 
			this.txtId.Enabled = false;
			this.txtId.Location = new System.Drawing.Point(95, 55);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(358, 21);
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
			// dvgCliente
			// 
			this.dvgCliente.Controls.Add(this.BtnEliminar);
			this.dvgCliente.Controls.Add(this.lblDatosNoEncontrados);
			this.dvgCliente.Controls.Add(this.txtBuscar);
			this.dvgCliente.Controls.Add(this.cmbBuscar);
			this.dvgCliente.Controls.Add(this.dgvCategoria);
			this.dvgCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dvgCliente.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.dvgCliente.Location = new System.Drawing.Point(548, 43);
			this.dvgCliente.Name = "dvgCliente";
			this.dvgCliente.Size = new System.Drawing.Size(697, 662);
			this.dvgCliente.TabIndex = 2;
			this.dvgCliente.TabStop = false;
			this.dvgCliente.Text = "Listado de Categoria";
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
			this.lblDatosNoEncontrados.Location = new System.Drawing.Point(260, 299);
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
            "Descripcion"});
			this.cmbBuscar.Location = new System.Drawing.Point(27, 28);
			this.cmbBuscar.Name = "cmbBuscar";
			this.cmbBuscar.Size = new System.Drawing.Size(121, 23);
			this.cmbBuscar.TabIndex = 1;
			this.cmbBuscar.Text = "Descripcion";
			this.cmbBuscar.SelectedIndexChanged += new System.EventHandler(this.cmbBuscar_SelectedIndexChanged);
			// 
			// dgvCategoria
			// 
			this.dgvCategoria.AllowUserToAddRows = false;
			this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
			this.dgvCategoria.Location = new System.Drawing.Point(27, 57);
			this.dgvCategoria.Name = "dgvCategoria";
			this.dgvCategoria.ReadOnly = true;
			this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvCategoria.Size = new System.Drawing.Size(657, 542);
			this.dgvCategoria.TabIndex = 0;
			this.dgvCategoria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellClick);
			this.dgvCategoria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellContentClick);
			this.dgvCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoria_CellDoubleClick);
			// 
			// Eliminar
			// 
			this.Eliminar.HeaderText = "Eliminar";
			this.Eliminar.Name = "Eliminar";
			this.Eliminar.ReadOnly = true;
			// 
			// txtFlag
			// 
			this.txtFlag.Enabled = false;
			this.txtFlag.Location = new System.Drawing.Point(483, 17);
			this.txtFlag.Name = "txtFlag";
			this.txtFlag.Size = new System.Drawing.Size(51, 20);
			this.txtFlag.TabIndex = 1;
			this.txtFlag.Visible = false;
			// 
			// FrmCategoria
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1303, 771);
			this.Controls.Add(this.dvgdatoCliente);
			this.Controls.Add(this.dvgCliente);
			this.Controls.Add(this.txtFlag);
			this.Name = "FrmCategoria";
			this.Text = "Mantenimiento de Categoria";
			this.Load += new System.EventHandler(this.FrmCategoria_Load);
			this.dvgdatoCliente.ResumeLayout(false);
			this.dvgdatoCliente.PerformLayout();
			this.dvgCliente.ResumeLayout(false);
			this.dvgCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox dvgdatoCliente;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnEditar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox dvgCliente;
		private System.Windows.Forms.Button BtnEliminar;
		private System.Windows.Forms.Label lblDatosNoEncontrados;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.ComboBox cmbBuscar;
		private System.Windows.Forms.DataGridView dgvCategoria;
		private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
		private System.Windows.Forms.TextBox txtFlag;
	}
}