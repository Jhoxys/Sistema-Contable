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
	public partial class FrmVenta : Form
	{
        private static DataTable dt = new DataTable();
        private string sResultado;
        private static FrmVenta _Instancia;
        public FrmVenta()
		{
			InitializeComponent();
		}

        public static FrmVenta Getinscance()
        {
            if (_Instancia == null)
                _Instancia = new FrmVenta();

            return _Instancia;

        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = FVenta.GetAll();

                dt = ds.Tables[0];
                dgvVenta.DataSource = dt;

                if (dt.Rows.Count > 0)
                {
                    lblDatosNoEncontrados.Visible = false;
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
			///smuliar click grilla
			dgvVenta_CellClick(null, null);


        }
		public void MostrarGuardarCancelar(bool b)
		{

			btnGuardar.Visible = b;
			btnCancelar.Visible = b;
			btnEditar.Visible = !b;
			btnNuevo.Visible = !b;
            btnBuscarCliente.Visible = b;
            // control para editar activar solo en editar
            dgvVenta.Enabled = !b;
            txtFecha.Enabled = b;
			cmbTipoDoc.Enabled = b;
            txtNumeroDoc.Enabled = b;

        }


		private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            FrmCliente frmcli = new FrmCliente();
            frmcli.SetFlag("1");
            frmcli.ShowDialog();
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

                        Venta venta = new Venta();
                        venta.Cliente.Id = int.Parse(txtClienteId.Text);
						venta.Cliente.Nombre = txtClienteNombre.Text;
						venta.FechaVenta = txtFecha.Value;
						venta.TipoDocumento = cmbTipoDoc.Text;
                        venta.NumeroDocumento = txtNumeroDoc.Text;

                        venta.Cliente.Nombre = txtClienteNombre.Text;
						if (FVenta.Insertar(venta) > 0)
                        {
                            MessageBox.Show("Datos Insertados Correctamente");
                            CargarDetalle(venta);
							FrmVenta_Load(null, null);

                        }
                    }
                    else
                    {/// parte de actualizar
                        Venta venta = new Venta();
						venta.Id = int.Parse(txtId.Text);
						venta.Cliente.Id = int.Parse(txtClienteId.Text);
						venta.Cliente.Nombre = txtClienteNombre.Text;
						venta.FechaVenta = txtFecha.Value;
						venta.TipoDocumento = cmbTipoDoc.Text;
						venta.NumeroDocumento = txtNumeroDoc.Text;

						if (FVenta.Actualizar(venta) == 1)
                        {
                            MessageBox.Show("Datos actualizados Correctamente");
							FrmVenta_Load(null, null);
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

        private void CargarDetalle(Venta venta)
        {
            throw new NotImplementedException();
        }

        public string ValidarDatos()
        {

            string resultado = "";

            // validar datos
            if (txtClienteId.Text == "")
            {
                resultado = resultado + " Nombre \n";
            }
            if (txtClienteNombre.Text == "")
            {
                resultado = resultado + " Apellido";
            }
            return resultado;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
			MostrarGuardarCancelar(false);
			dgvVenta_CellClick(null, null);
		}

        private void btnEditar_Click(object sender, EventArgs e)
        {
			MostrarGuardarCancelar(true);
		}

        private void btnNuevo_Click(object sender, EventArgs e)
        {
			MostrarGuardarCancelar(true);

            txtId.Text = "";
            txtClienteId.Text = "";
            txtClienteNombre.Text = "";
            txtFecha.Text = "";
            cmbTipoDoc.Text = "";
            txtNumeroDoc.Text = "";
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
			try
			{
				DataView dv = new DataView(dt.Copy()); // copiamso la tabla de resultado de base de datos
				dv.RowFilter = cmbBuscar.Text + " Like '" + txtBuscar.Text + "%'";

				dgvVenta.DataSource = dv;

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


		private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvVenta.CurrentRow != null)
			{

				txtId.Text = dgvVenta.CurrentRow.Cells["Id"].Value.ToString();
                txtClienteId.Text = dgvVenta.CurrentRow.Cells["ClienteId"].Value.ToString();
                txtClienteNombre.Text = dgvVenta.CurrentRow.Cells["Nombre"].Value.ToString() +"-"+ dgvVenta.CurrentRow.Cells["Apellido"].Value.ToString();
                txtFecha.Text = dgvVenta.CurrentRow.Cells["FechaVenta"].Value.ToString();
                cmbTipoDoc.Text = dgvVenta.CurrentRow.Cells["TipoDocumento"].Value.ToString();
                txtNumeroDoc.Text = dgvVenta.CurrentRow.Cells["NumeroDocumento"].Value.ToString();

            }
		}

		private void dgvVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//if (e.ColumnIndex == dgvVenta.Columns["Eliminar"].Index)
			//{

			//	DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvVenta.Rows[e.RowIndex].Cells["Eliminar"];
			//	chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);

			//}

			
		}

        internal void setCliente(string sIdCliente, string sNombreCliente)
        {
            txtClienteId.Text = sIdCliente;  
            txtClienteNombre.Text = sNombreCliente;
        }
    }
}
