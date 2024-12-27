using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
	public class Productos
	{
		private int _id;
		private Categoria _categoria;
		private string _nombre;
		private string _descripcion;
		private double _stock;
		private double _precioCompra; 
		private double _precioVenta;
		private DateTime _fechaVencimiento;
		private byte [] _imagen;

		public Productos(int id, Categoria categoria, string nombre, string descripcion, double stock, double precioCompra, double precioVenta, DateTime fechaVencimiento, byte[] imagen)
		{
			_id = id;
			_categoria = categoria;
			_nombre = nombre;
			_descripcion = descripcion;
			_stock = stock;
			_precioCompra = precioCompra;
			_precioVenta = precioVenta;
			_fechaVencimiento = fechaVencimiento;
			_imagen = imagen;
		}
		public Productos() {

			_categoria=new Categoria();
		}

		public int Id { get => _id; set => _id = value; }
		public Categoria Categoria { get => _categoria; set => _categoria = value; }
		public string Nombre { get => _nombre; set => _nombre = value; }
		public string Descripcion { get => _descripcion; set => _descripcion = value; }
		public double Stock { get => _stock; set => _stock = value; }
		public double PrecioCompra { get => _precioCompra; set => _precioCompra = value; }
		public double PrecioVenta { get => _precioVenta; set => _precioVenta = value; }
		public DateTime FechaVencimiento { get => _fechaVencimiento; set => _fechaVencimiento = value; }
		public byte[] Imagen { get => _imagen; set => _imagen = value; }
	}
}
