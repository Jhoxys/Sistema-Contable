using SistemaVentas.Entidades;
using SisVenttas.Datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Datos
{
	public class FDetalleVenta
	{


		public static DataSet GetAll()
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					//FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, gasto.Id),
				};
			return FDBHelper.ExecuteDataSet("usp_Datos_FDetalleVenta_GetAll", dbParams);

		}


		public static int Insertar(DetalleVenta detalleventa)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					//[Id], [VentaId], [ProductoId], [Cantidad], [PrecioUnitario]
					FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, detalleventa.Id),
					FDBHelper.MakeParam("@VentaId", SqlDbType.VarChar, 0, detalleventa.Venta.Id),
					FDBHelper.MakeParam("@ProductoId", SqlDbType.VarChar, 0, detalleventa.Producto.Id),
					FDBHelper.MakeParam("@Cantidad", SqlDbType.Int, 0, detalleventa.Cantidad),
					FDBHelper.MakeParam("@PrecioUnitario", SqlDbType.VarChar, 0, detalleventa.PrecioUnitario)
				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FDetalleVenta_Insertar", dbParams));

		}


		public static int Actualizar(DetalleVenta detalleventa)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
			     	FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, detalleventa.Id),
					FDBHelper.MakeParam("@VentaId", SqlDbType.VarChar, 0, detalleventa.Venta.Id),
					FDBHelper.MakeParam("@ProductoId", SqlDbType.VarChar, 0, detalleventa.Producto.Id),
					FDBHelper.MakeParam("@Cantidad", SqlDbType.Int, 0, detalleventa.Cantidad),
					FDBHelper.MakeParam("@PrecioUnitario", SqlDbType.VarChar, 0, detalleventa.PrecioUnitario)
				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FDetalleVenta_Actualizar", dbParams));

		}

		public static int Eliminar(DetalleVenta detalleventa)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, detalleventa.Id),

				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FDetalleVenta_Eliminar", dbParams));

		}


	}



}
