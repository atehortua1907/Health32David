using Health32David.Backend.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32David.Backend.DAC.Clases
{
    public class PacienteDAC
    {
        public static void CrearPaciente(PacienteBE pacienteBE)
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection(Common.Conection.ConnString))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("dbo.Paciente_Konecta_i", cnn))
                    {

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Nombre", pacienteBE.Nombre);
                        cmd.Parameters.AddWithValue("@Apellido", pacienteBE.Apellido);
                        cmd.Parameters.AddWithValue("@TipoDoc", pacienteBE.TipoDoc);
                        cmd.Parameters.AddWithValue("@NumDoc", pacienteBE.NumDoc);
                        cmd.Parameters.AddWithValue("@FechaNac", pacienteBE.FechaNac);
                        cmd.Parameters.AddWithValue("@EstadoCivil", pacienteBE.EstadoCivil);
                        cmd.Parameters.AddWithValue("@Sexo", pacienteBE.Sexo);
                        cmd.Parameters.AddWithValue("@Foto", pacienteBE.Foto);

                        cmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@NumReferencia",
                            SqlDbType = SqlDbType.UniqueIdentifier,
                            Direction = ParameterDirection.Output
                        });

                        var i = cmd.ExecuteNonQuery();

                        //inserted.Id
                        pacienteBE.NumDoc = cmd.Parameters["@NumDoc"].SqlValue.ToString();
                    }

                }

            }
            catch (Exception ex)
            {
                throw Fwk.Exceptions.ExceptionHelper.ProcessException(ex);
            }
        }

    }
}
