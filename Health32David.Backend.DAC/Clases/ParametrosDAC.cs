using Health32David.Backend.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32David.Backend.DAC
{
    public class ParametrosDAC
    {
        #region Metodos
        public static ParametrosBEList BuscarParametros()
        {
            ParametrosBEList ListaParametros = new ParametrosBEList();

            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Conection.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Param_Konecta_s", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ParametrosBE item = new ParametrosBE();
                                item.Id_Params = int.Parse(reader["Id_Params"].ToString());
                                item.Nombre = Convert.ToString(reader["Nombre"]);
                                item.Descripcion = Convert.ToString(reader["Descripcion"]);
                                item.Tipo_Param = int.Parse(reader["Tipo_Param"].ToString());
                                ListaParametros.Add(item);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }

            return ListaParametros;
        }
        #endregion

    }
}
