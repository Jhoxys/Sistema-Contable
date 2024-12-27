using System;
using SistemaVentas.Datos;

using System.Data;

using System.Windows.Forms;
using SistemaVentas.Entidades;

namespace SistemaVentas.Presentacion
{
	public partial class FrmCliente : Form
	{  private static DataTable dt= new DataTable();
		private string sResultado;
		public FrmCliente()
		{
			InitializeComponent();
		}

		private void FrmCliente_Load(object sender, EventArgs e)
		{
			try
			{

			DataSet ds = FCliente.GetAll();
			
			      dt = ds.Tables[0];	
				  dgvClientes.DataSource = dt;

				if( dt.Rows.Count > 0 )
				{
					lblDatosNoEncontrados.Visible = false;
				}else {
					lblDatosNoEncontrados.Visible = true;
				}
			
			}catch( Exception ex){

				MessageBox.Show(ex.Message+ex.StackTrace);
			
			}

			MostrarGuardarCancelar(false);
			///smuliar click grilla
			dgvClientes_CellClick(null, null);

		}

		private void btnGuardar_Click(object sender, EventArgs e)
		{
			try
			{
				 sResultado = ValidarDatos();

                if ( sResultado.Equals("")) {
				if(txtId.Text == "") // validar si es un registro nuevo o es  para editar
				{

				Cliente cliente = new Cliente();
				cliente.Nombre = txtNombre.Text;
				cliente.Apellido = txtApellido.Text;
				cliente.Telefono = txtTelefono.Text;
				cliente.Dni = Convert.ToInt32(txtDni.Text);
				cliente.Domnicilio = txtDomicilio.Text;

				if (FCliente.Insertar(cliente) > 0)
				{
					MessageBox.Show("Datos Insertados Correctamente");
					FrmCliente_Load(null, null);
				}
				}else
				{/// parte de actualizar
					Cliente cliente = new Cliente();
					cliente.Id = Convert.ToInt32(txtId.Text); 
					cliente.Nombre = txtNombre.Text;
					cliente.Apellido = txtApellido.Text;
					cliente.Telefono = txtTelefono.Text;
					cliente.Dni = Convert.ToInt32(txtDni.Text);
					cliente.Domnicilio = txtDomicilio.Text;

					if (FCliente.Actualizar(cliente) == 1)
					{
						MessageBox.Show("Datos actualizados Correctamente");
						FrmCliente_Load(null, null);
					}
				}
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


		public string ValidarDatos()
		{

           string resultado = "";
 
			// validar datos
			if(txtNombre.Text == "")
			{
				resultado = resultado + " Nombre \n";
			}
			if (txtApellido.Text == "")
			{
				resultado = resultado + " Apellido";
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
            dvgCliente.Enabled = !b;
		     // control para editar activar solo en editar
			txtApellido.Enabled = b;
			txtNombre.Enabled = b;
			txtDni.Enabled = b;
			txtTelefono.Enabled = b;
			txtDomicilio.Enabled = b;

		}
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            // boton nuevo
            MostrarGuardarCancelar(true);
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDni.Text = "";
            txtTelefono.Text = "";
            txtDomicilio.Text = "";
        }
		private void btnEditar_Click(object sender, EventArgs e)
		{
			MostrarGuardarCancelar(true);
		}
		private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
			dgvClientes_CellClick(null, null);

		}


		private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // click a la celda
			if(dgvClientes.CurrentRow !=null) { 

            txtId.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString(); 
			txtNombre.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtApellido.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            txtDni.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtDomicilio.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();

			}
		}

		private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == dgvClientes.Columns["Eliminar"].Index) { 
			    
				 DataGridViewCheckBoxCell chkEliminar= (DataGridViewCheckBoxCell) dgvClientes.Rows[e.RowIndex].Cells["Eliminar"];
				chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
			
			}
		}

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
			try
			{

				if (MessageBox.Show("¿Realmente deseas eliminar los clientes seleccionados?", "Eliminacion de clientes", MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK )
				{
                    foreach (DataGridViewRow row in dgvClientes.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells["Eliminar"].Value))
                        {
                            Cliente cliente = new Cliente();
                            cliente.Id = Convert.ToInt32(row.Cells["Id"].Value); // obtenemos el ID de la celda y lo pasamos a la clase cliente
                            if (FCliente.Eliminar(cliente) != 1)
                            {
                                MessageBox.Show("El cliente no pudo ser eliminado ", " Eliminacion de Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }

                        }

                    }
                    FrmCliente_Load(null, null);
                }

			
			}
			catch (Exception ex)
			{

				MessageBox.Show (ex.Message + ex.StackTrace);
			}
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
			try
			{
				DataView dv = new DataView(dt.Copy() ); // copiamso la tabla de resultado de base de datos
				dv.RowFilter= cmbBuscar.Text +" Like '"+ txtBuscar.Text+ "%'";

				dgvClientes.DataSource = dv;

				if(dv.Count ==0)
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
        public void SetFlag(String band)
        {
            txtFlag.Text = band;
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtFlag.Text == "1")
            { // 

                FrmVenta frmPro = FrmVenta.Getinscance();

                if (dgvClientes.CurrentRow != null)
                {

                    frmPro.setCliente(dgvClientes.CurrentRow.Cells[1].Value.ToString(), dgvClientes.CurrentRow.Cells[2].Value.ToString());
                    frmPro.Show();
                    Close();
                }

            }
        }

     
    }
}
