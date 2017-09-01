using Fwk.Bases;
using Health32David.Backend.DAC;
using Health32David.Backend.ISVC.Buscar;

namespace Health32David.Backend.SVC
{
    public class BuscarParametrosSVC : BusinessService<BuscarParametrosReq, BuscarParametrosRes>
    {
        public override BuscarParametrosRes Execute(BuscarParametrosReq pServiceRequest)
        {
            var responseBuscarParametros = new BuscarParametrosRes();

            responseBuscarParametros.BusinessData = ParametrosDAC.BuscarParametros();

            return responseBuscarParametros;
        }
    }
}
