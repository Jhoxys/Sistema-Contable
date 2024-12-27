using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
	public class Cliente
	{
		private  int _id;
		private string _nombre;
		private string _apellido;
		private string _domnicilio;
		private string _telefono;
		private int _dni;

		public int Id {	get => _id; set => _id = value; }
		public string Nombre { get => _nombre; set => _nombre = value; }
		public string Apellido { get => _apellido; set => _apellido = value; }
		public string Telefono { get => _telefono; set => _telefono = value; }
		public int Dni { get => _dni; set => _dni = value; }
		public string Domnicilio { get => _domnicilio; set => _domnicilio = value; }

		public Cliente() { }

		public Cliente(int id, string nombre, string apellido, string telefono, int dni, string domnicilio)
		{
			this._id = id;
			this._nombre = nombre;
			this._apellido = apellido;
			this._telefono = telefono;
			this._domnicilio = domnicilio;
			this._dni = id;
		}	
	}


}
