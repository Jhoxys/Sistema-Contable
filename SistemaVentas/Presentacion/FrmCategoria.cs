using SistemaVentas.Datos;
using SistemaVentas.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas.Presentacion
{
	public partial class FrmCategoria : Form
	{
		private static DataTable dt = new DataTable();
		private string sResultado;
		public FrmCategoria()
		{
			InitializeComponent();
		}

	

		private void FrmCategoria_Load(object sender, EventArgs e)
		{
			try
			{

				DataSet ds = FCategoria.GetAll();

				dt = ds.Tables[0];
				dgvCategoria.DataSource = dt;

				if (dt.Rows.Count > 0)
				{
					lblDatosNoEncontrados.Visible = false;
					dgvCategoria_CellClick(null, null);
				}
				else
				{
					lblDatosNoEncontrados.Visible = true;
				}

			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);

			}

		          MostrarGuardarCancelar(false);
			/////smuliar click grilla
			//

		}
		public void SetFlag(String valor)
		{
			txtFlag.Text = valor;
		}

		private void cmbBuscar_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				sResultado = ValidarDatos();

				if (sResultado.Equals(""))
				{
					if (txtId.Text == "") // validar si es un registro nuevo o es  para editar
					{

						Categoria categoria = new Categoria();
						categoria.Descripcion = txtNombre.Text;
						

						if (FCategoria.Insertar(categoria) > 0)
						{
							MessageBox.Show("Datos Insertados Correctamente");
							FrmCategoria_Load(null, null);
						}
					}
					else
					{/// parte de actualizar
						Categoria categoria = new Categoria();
						categoria.Id = Convert.ToInt32(txtId.Text);
						categoria.Descripcion = txtNombre.Text;
					
						if (FCategoria.Actualizar(categoria) == 1)
						{
							MessageBox.Show("Datos actualizados Correctamente");
							FrmCategoria_Load(null, null);
						}
					}//
				}
				else
				{
					MessageBox.Show("Faltan cargar Datos \n" + sResultado);
				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);

			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			MostrarGuardarCancelar(false);
			dgvCategoria_CellClick(null, null);
		}

		private void btnNuevo_Click(object sender, EventArgs e)
		{
			// boton nuevo
			MostrarGuardarCancelar(true);
			txtNombre.Text = "";
			txtId.Text = "";

		}

		private void btnEditar_Click(object sender, EventArgs e)
		{
			MostrarGuardarCancelar(true);
		}

		private void BtnEliminar_Click(object sender, EventArgs e)
		{

			try
			{

				if (MessageBox.Show("¿Realmente deseas eliminar las categorias seleccionadas?", "Eliminacion de categoria", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
				{
					foreach (DataGridViewRow row in dgvCategoria.Rows)
					{
						if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
						{
							Categoria categoria = new Categoria();
							categoria.Id = Convert.ToInt32(row.Cells["Id"].Value); // obtenemos el ID de la celda y lo pasamos a la clase cliente
							if (FCategoria.Eliminar(categoria) != 1)
							{
								MessageBox.Show("La catgegoria no pudo ser eliminada ", " Eliminacion de categoria", MessageBoxButtons.OK, MessageBoxIcon.Warning);

							}

						}

					}
					FrmCategoria_Load(null, null);
				}


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);
			}
		}

		private void txtBuscar_TextChanged(object sender, EventArgs e)
		{
			try
			{
				DataView dv = new DataView(dt.Copy()); // copiamso la tabla de resultado de base de datos
				dv.RowFilter = cmbBuscar.Text + " Like '" + txtBuscar.Text + "%'";

				dgvCategoria.DataSource = dv;

				if (dv.Count == 0)
				{
					lblDatosNoEncontrados.Visible = true;

				}
				else
				{
					lblDatosNoEncontrados.Visible = false;

				}
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message + ex.StackTrace);
			}
		}

		private void dgvCategoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dgvCategoria.Columns["Eliminar"].Index)
			{

				DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvCategoria.Rows[e.RowIndex].Cells["Eliminar"];
				chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);

			}
		}

		private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvCategoria.CurrentRow != null)
			{

				txtId.Text = dgvCategoria.CurrentRow.Cells[1].Value.ToString();
				txtNombre.Text = dgvCategoria.CurrentRow.Cells[2].Value.ToString();
				

			}
		}

		public string ValidarDatos()
		{

			string resultado = "";

			// validar datos
			if (txtNombre.Text == "")
			{
				resultado = resultado + " Categoria \n";
			}
		
			return resultado;
		}


		public void MostrarGuardarCancelar(bool b)
		{

			btnGuardar.Visible = b;
			btnCancelar.Visible = b;
			btnEditar.Visible = !b;
			btnNuevo.Visible = !b;
			BtnEliminar.Visible = !b;
			dgvCategoria.Enabled = !b;

			// control para editar activar solo en editar

			txtNombre.Enabled = b;
		

		}

		private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if(txtFlag.Text == "1") { // 

			frmProductos frmPro= frmProductos.Getinscance();
		
				if (dgvCategoria.CurrentRow != null)
			{

				frmPro.setCategoria(dgvCategoria.CurrentRow.Cells[1].Value.ToString(), dgvCategoria.CurrentRow.Cells[2].Value.ToString());
				frmPro.Show();
				Close();
			}

			}
		}
	}
}
