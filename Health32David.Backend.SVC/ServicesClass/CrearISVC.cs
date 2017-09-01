using Fwk.Bases;
using Health32David.Backend.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32David.Backend.ISVC.Crear
{
    public class CrearPacienteReq : Request<PacienteBE>
    {
        public CrearPacienteReq()
        {
            this.ServiceName = "CrearPacienteSVC";
        }
    }

    public class CrearPacienteRes : Response<ResultPaciente>
    {
    }

    public class ResultPaciente : BaseEntity
    {
        public Int32 NumReferencia { get; set; }
    }
}
