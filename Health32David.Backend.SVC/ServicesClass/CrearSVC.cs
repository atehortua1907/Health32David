using Fwk.Bases;
using Health32David.Backend.DAC;
using Health32David.Backend.DAC.Clases;
using Health32David.Backend.ISVC.Crear;

namespace Health32David.Backend.SVC
{
    public class CrearPacienteSVC : BusinessService<CrearPacienteReq, CrearPacienteRes>
    {
        public override CrearPacienteRes Execute(CrearPacienteReq pServiceRequest)
        {
            var responseCrearPaciente = new CrearPacienteRes();

            PacienteDAC.CrearPaciente(pServiceRequest.BusinessData);

            return responseCrearPaciente;
        }
    }
}
