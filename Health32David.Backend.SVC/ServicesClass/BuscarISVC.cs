using Fwk.Bases;
using Health32David.Backend.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32David.Backend.ISVC.Buscar
{
    #region Interfaz de Servicio Buscar Parametros
    public class BuscarParametrosReq : Request<ParametrosBE>
    {
        public BuscarParametrosReq()
        {
            this.ServiceName = "BuscarParametrosSVC";
        }
    }

    public class BuscarParametrosRes : Response<ParametrosBEList>
    {

    } 
    #endregion

    #region Interfaz de Servicio Buscar Buscar Documento Existente
    public class BuscarDctoExistenteReq : Request<BuscarDctoExistente>
    {
        public BuscarDctoExistenteReq()
        {
            this.ServiceName = "BuscarDctoExistenteSVC";
        }
    }

    public class BuscarDctoExistente : BaseEntity
    {
        public bool HayDocumento { get; set; }
    }

    public class BuscarDctoExistenteRes : Response<BuscarDctoExistenteResult>
    {

    }

    public class BuscarDctoExistenteResult : BaseEntity
    {
        public bool HayDocumento { get; set; }
    } 
    #endregion
}
