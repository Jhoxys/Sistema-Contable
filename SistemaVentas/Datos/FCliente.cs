using SistemaVentas.Entidades;
using SisVenttas.Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Datos
{
	public class FCliente
	{
		public static DataSet GetAll()
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					//FDBHelper.MakeParam("@Id", SqlDbType.Int, 0, gasto.Id),
				};
			return FDBHelper.ExecuteDataSet("usp_Datos_FCliente_GetAll", dbParams);

		}


		public static int Insertar(Cliente cliente)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
					FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, cliente.Apellido),
					FDBHelper.MakeParam("@Dni", SqlDbType.Int, 0, cliente.Dni),
					FDBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domnicilio),
					FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
				};
			return Convert.ToInt32( FDBHelper.ExecuteScalar("usp_Datos_FCliente_Insertar", dbParams));

		}


		public static int Actualizar(Cliente cliente)
		{
			SqlParameter[] dbParams = new SqlParameter[]
				{
					FDBHelper.MakeParam("@id", SqlDbType.Int, 0, cliente.Id),
					FDBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre),
					FDBHelper.MakeParam("@Apellido", SqlDbType.VarChar, 0, cliente.Apellido),
					FDBHelper.MakeParam("@Dni", SqlDbType.Int, 0, cliente.Dni),
					FDBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domnicilio),
					FDBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
				};
			return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FCliente_Actualizar", dbParams));

		}

        public static int Eliminar(Cliente cliente)
        {
            SqlParameter[] dbParams = new SqlParameter[]
                {
                    FDBHelper.MakeParam("@id", SqlDbType.Int, 0, cliente.Id),
             
                };
            return Convert.ToInt32(FDBHelper.ExecuteScalar("usp_Datos_FCliente_Eliminar", dbParams));

        }

    }
}
