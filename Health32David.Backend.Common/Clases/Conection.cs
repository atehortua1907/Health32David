
namespace Health32David.Backend.Common
{
    public class Conection
    {
        #region Conexión BD
        const string ConStringName = "cnncapa";
        public static string ConnString = string.Empty;
        static Conection()
        {
            if (System.Configuration.ConfigurationManager.ConnectionStrings[ConStringName] != null)
                ConnString = System.Configuration.ConfigurationManager.ConnectionStrings[ConStringName].ConnectionString;
            else
                throw new Fwk.Exceptions.TechnicalException("Está Faltando la Cadena de Conexion");
        }
        #endregion
    }
}
