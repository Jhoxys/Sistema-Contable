using SistemaVentas.Datos;
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
    public partial class FrmDetalleVenta : Form
    {

        private static FrmDetalleVenta _Instancia=null;

        public FrmDetalleVenta()
        {
            InitializeComponent();
        }

        public static FrmDetalleVenta Getinscance()
        {
           if (_Instancia == null)
            {
                _Instancia = new FrmDetalleVenta();

            }
            return _Instancia;
        }

        public void setProductos(string SproID, string SProDescrip)
        {
            txtProductoId.Text = SproID;
            txtProductoDescription.Text = SProDescrip;
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmProductos frmProd = new frmProductos();
            frmProd.SetFlag("1");
            frmProd.ShowDialog();
        }

        private void dvgdatoCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
