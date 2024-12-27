using SistemaVentas.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Entidades
{
    public class Venta
    {
        //[Id], [ClienteId], [FechaVenta], [NumeroDocumento], [TipoDocumento]

        private int _id;
        private Cliente _cliente;
        private DateTime _fechaVenta;
        private string _numeroDocumento;
        private string _tipoDocumento;

        public int Id { get => _id; set => _id = value; }

        public DateTime FechaVenta { get => _fechaVenta; set => _fechaVenta = value; }
        public string NumeroDocumento { get => _numeroDocumento; set => _numeroDocumento = value; }
        public string TipoDocumento { get => _tipoDocumento; set => _tipoDocumento = value; }
		public Cliente Cliente { get => _cliente; set => _cliente = value; }

		public Venta() {


			Cliente = new Cliente();

        }


    }



}
