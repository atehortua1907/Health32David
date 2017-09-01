using Fwk.Exceptions;
using Health32David.Backend.Common;
using Health32David.Backend.ISVC.Buscar;
using Health32David.Backend.ISVC.Crear;
using System;

namespace Health32David.FrontEnd
{
    public class ServiceCall
    {
        internal static ParametrosBEList BuscarParametros()
        {
            var req = new BuscarParametrosReq();

            var res = req.ExecuteService<BuscarParametrosReq, BuscarParametrosRes>(req);


            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res.BusinessData;
        }

        internal static object CrearPaciente(PacienteBE Paciente)
        {
            CrearPacienteReq req = new CrearPacienteReq();

            req.BusinessData = Paciente;


            CrearPacienteRes res = req.ExecuteService<CrearPacienteReq, CrearPacienteRes>(req);


            if (res.Error != null)
            {
                Exception ex = ExceptionHelper.ProcessException(res.Error);
                throw ex;
            }

            return res;
        }

        

    }
}
