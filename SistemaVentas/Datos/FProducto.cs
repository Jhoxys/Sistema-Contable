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
	public class FProducto
	{
		public static DataSet GetAll()
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					//FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, gasto.Id),
				};
			return FDBHelper.ExecuteDataSet("usp_Datos_FProducto_GetAll", dbParams);

		}

		public static int Insertar(Productos productos)
		{ 
			SqlParameter[] dbParams = new SqlParameter[]
				{   //[Id], [CategoriaId], [Nombre], [Descripcion], [Stock], [PrecioCompra], [PrecioVenta], [FechaVencimiento], [FechaCreado], [Imagen]
				    FDBHelper.MakeParam("@CategoriaId", SqlDbType.Int, 0,  productos.Categoria.Id),
					FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, productos.Nombre),
					FDBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, productos.Descripcion),
					FDBHelper.MakeParam("@Stock", SqlDbType.Decimal, 0, productos.Stock),
					FDBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, productos.PrecioVenta),
					FDBHelper.MakeParam("@PrecioCompra", SqlDbType.Decimal, 0, productos.PrecioCompra),
					FDBHelper.MakeParam("@FechaVencimiento", SqlDbType.DateTime, 0, productos.FechaVencimiento),
					//FDBHelper.MakeParam("@FechaCreado", SqlDbType.DateTime, 0, productos.FechaVenta),
					FDBHelper.MakeParam("@Imagen", SqlDbType.Image, 0, productos.Imagen)
				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FProducto_Insertar", dbParams));

		}


		public static int Actualizar(Productos productos)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, productos.Id),
				    FDBHelper.MakeParam("@CategoriaId", SqlDbType.Int, 0, productos.Categoria.Id),
					FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, productos.Nombre),
					FDBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, productos.Descripcion),
					FDBHelper.MakeParam("@Stock", SqlDbType.Decimal, 0, productos.Stock),
					FDBHelper.MakeParam("@PrecioVenta", SqlDbType.Decimal, 0, productos.PrecioVenta),
					FDBHelper.MakeParam("@PrecioCompra", SqlDbType.Decimal, 0, productos.PrecioCompra),
					FDBHelper.MakeParam("@FechaVencimiento", SqlDbType.DateTime, 0, productos.FechaVencimiento),
				//	FDBHelper.MakeParam("@FechaCreado", SqlDbType.DateTime, 0, productos.FechaVenta),
					FDBHelper.MakeParam("@Imagen", SqlDbType.Image, 0, productos.Imagen)
				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FProducto_Actualizar", dbParams));

		}

		public static int Eliminar(Productos productos)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, productos.Id),

				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FProducto_Eliminar", dbParams));

		}
	}
}
