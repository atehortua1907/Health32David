using Fwk.Bases;
using Health32David.Backend.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32David.Backend.ISVC.Buscar
{
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
}
