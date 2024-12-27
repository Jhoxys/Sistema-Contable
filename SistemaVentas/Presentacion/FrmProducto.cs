using SistemaVentas.Datos;
using SistemaVentas.Entidades;
using SistemaVentas.Properties;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System;


namespace SistemaVentas.Presentacion
{
    public partial class frmProductos : Form
    {
        private static DataTable dt = new DataTable();
        private string sResultado;
        private static frmProductos _Instancia;

        public frmProductos()
        {
            InitializeComponent();
            //frmProductos_Load();

        }


        // Si existe instancia entonces  cargo lainstancia pero sino entonces creo una y retorno
        public static frmProductos Getinscance()
        {
            if (_Instancia == null)
                _Instancia = new frmProductos();

            return _Instancia;

        }
        
        public void SetFlag(string flag)
        {
            txtFlag.Text = flag;
        }

        public void setCategoria(string id, string descripcion)
        {
            txtCategoriaId.Text = id;
            textCategoriaDescripcion.Text = descripcion;


        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                Imagen.BackgroundImage = null;
                Imagen.Image = new Bitmap(dialogo.FileName);
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            Imagen.BackgroundImage = Resources._56296;
            Imagen.Image = null;
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
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

                        Productos producto = new Productos();
                        producto.Nombre = txtNombre.Text;
                        producto.Categoria.Id = Convert.ToInt32(txtCategoriaId.Text);
                        producto.Descripcion = textCategoriaDescripcion.Text;
                        producto.Stock = Convert.ToDouble(textStock.Text);
                        producto.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                        producto.PrecioVenta = Convert.ToDouble(textPrecioVenta.Text);
                        producto.FechaVencimiento = txtFechaVencimiento.Value;

                        MemoryStream ms = new MemoryStream();

                        if (Imagen.Image != null)
                        {
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat); //Gardamos en memoria la img
                        }
                        else
                        {
                            Imagen.Image = Resources._56296;  //Imagen transparente
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat); //Gardamos en memoria la img

                        }
                        producto.Imagen = ms.GetBuffer();

                        if (FProducto.Insertar(producto) > 0)
                        {
                            MessageBox.Show("Datos Insertados Correctamente");
                            frmProductos_Load(null, null);
                        }
                    }
                    else
                    {/// parte de actualizar

                        Productos producto = new Productos();
                        producto.Nombre = txtNombre.Text;
                        producto.Id = Convert.ToInt32(txtId.Text);
                        producto.Categoria.Id = Convert.ToInt32(txtCategoriaId.Text);
                        producto.Descripcion = textCategoriaDescripcion.Text;
                        producto.Stock = Convert.ToDouble(textStock.Text);
                        producto.PrecioCompra = Convert.ToDouble(txtPrecioCompra.Text);
                        producto.PrecioVenta = Convert.ToDouble(textPrecioVenta.Text);
                        producto.FechaVencimiento = txtFechaVencimiento.Value;
                        MemoryStream ms = new MemoryStream();

                        if (Imagen.Image != null)
                        {
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat); //Gardamos en memoria la img
                        }
                        else
                        {
                            Imagen.Image = Resources._56296;  //Imagen transparente
                            Imagen.Image.Save(ms, Imagen.Image.RawFormat); //Gardamos en memoria la img
                        }
                        producto.Imagen = ms.GetBuffer();
                        MessageBox.Show("Datos llegan Correctamente"+ producto.Imagen);
                        if (FProducto.Actualizar(producto) == 1)
                        {
                            MessageBox.Show("Datos actualizados Correctamente");
                            frmProductos_Load(null, null);
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
            if (txtNombre.Text == "")
            {
                resultado = resultado + " Nombre \n";
            }

            return resultado;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
            txtId.Text = "";
            txtCategoriaId.Text = "";
            textCategoriaDescripcion.Text = "";
            textStock.Text = "";
            txtPrecioCompra.Text = "";
            textPrecioVenta.Text = "";
            txtFechaVencimiento.Value = DateTime.Today;
            txtPrecioCompra.Text = "";
            txtNombre.Text = "";
            txtDecripcion.Text = "";
            Imagen.BackgroundImage = Resources._56296;
            Imagen.Image = null;
            Imagen.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(false);
            dgvProducto_CellClick(null, null);
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MostrarGuardarCancelar(true);
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Realmente deseas eliminar los clientes seleccionados?", "Eliminacion de clientes", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    foreach (DataGridViewRow row in dgvProducto.Rows)
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
               frmProductos_Load(null, null);//
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnBuscarCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmcate = new FrmCategoria();
            frmcate.SetFlag("1");
            frmcate.ShowDialog();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // click a la celda
            if (dgvProducto.CurrentRow != null)
            {
                //  					Imagen
                txtId.Text = dgvProducto.CurrentRow.Cells["Id"].Value.ToString();
                txtCategoriaId.Text = dgvProducto.CurrentRow.Cells["CategoriaId"].Value.ToString();
                txtNombre.Text = dgvProducto.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDecripcion.Text = dgvProducto.CurrentRow.Cells["ProductoDescripcion"].Value.ToString();
                textCategoriaDescripcion.Text = dgvProducto.CurrentRow.Cells["Descripcion"].Value.ToString();
                textStock.Text = dgvProducto.CurrentRow.Cells["Stock"].Value.ToString();
                txtPrecioCompra.Text = dgvProducto.CurrentRow.Cells["PrecioCompra"].Value.ToString();
                textPrecioVenta.Text = dgvProducto.CurrentRow.Cells["PrecioVenta"].Value.ToString();
                txtFechaVencimiento.Text = dgvProducto.CurrentRow.Cells["FechaVencimiento"].Value.ToString();
                Imagen.BackgroundImage = null;
                byte[] b = (byte[])dgvProducto.CurrentRow.Cells["Imagen"].Value;
                MemoryStream memoryStream = new MemoryStream(b);
                Imagen.Image = Image.FromStream(memoryStream);
                Imagen.SizeMode = PictureBoxSizeMode.StretchImage;



            }

        }

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // click a la celda
            if (e.ColumnIndex == dgvProducto.Columns["Eliminar"].Index)
            {

                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvProducto.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);

            }
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            try
            {

                DataSet ds = FProducto.GetAll();


                dt = ds.Tables[0];
                dgvProducto.DataSource = dt;
        
                if (dt.Rows.Count > 0)
                {
                    //  MessageBox.Show("esto es " + ds);
                    dgvProducto.Columns["Imagen"].Visible = false;
                    dgvProducto_CellClick(null, null);
                    lblDatosNoEncontrados.Visible = false;
                }
                else
                {
                    //MessageBox.Show("esto es " + ds);
                    lblDatosNoEncontrados.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);

            }

            MostrarGuardarCancelar(false);
            ///smuliar click grilla
            //dgvProduto_CellClick(null, null);
        }

        public void MostrarGuardarCancelar(bool b)
        {

            btnGuardar.Visible = b;
            btnCancelar.Visible = b;
            btnEditar.Visible = !b;
            btnNuevo.Visible = !b;
            BtnEliminar.Visible = !b;
            dgvProducto.Enabled = !b;
            btnCambiar.Visible = b;
            btnQuitar.Visible = b;
            btnBuscarCategoria.Visible = b;
            // control para editar activar solo en editar
            txtCategoriaId.Enabled = b;
            textCategoriaDescripcion.Enabled = b;
            textStock.Enabled = b;
            txtPrecioCompra.Enabled = b;
            textPrecioVenta.Enabled = b;
            txtPrecioCompra.Enabled = b;
            txtNombre.Enabled = b;
            txtDecripcion.Enabled = b; 
            txtFechaVencimiento.Enabled = b;
       





        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dt.Copy()); // copiamso la tabla de resultado de base de datos
                dv.RowFilter = cmbBuscar.Text + " Like '" + txtBuscar.Text + "%'";

                dgvProducto.DataSource = dv;

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

        private void dgvProducto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtFlag.Text == "1")
            { // 

                FrmDetalleVenta frmDetVent = FrmDetalleVenta.Getinscance();

                if (dgvProducto.CurrentRow != null)
                {

                    frmDetVent.setProductos(dgvProducto.CurrentRow.Cells[1].Value.ToString(), dgvProducto.CurrentRow.Cells[2].Value.ToString());
                    frmDetVent.Show();
                    Close();
                }

            }
        }
    }


}