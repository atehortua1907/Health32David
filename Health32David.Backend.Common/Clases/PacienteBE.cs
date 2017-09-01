using Fwk.Bases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health32David.Backend.Common
{
    public partial class PacienteBEList : BaseEntities<PacienteBE> { }

    public partial class PacienteBE : BaseEntity
    {
        #region Atributos
        private Guid _NumReferencia;
        private String _Nombre;
        private String _Apellido;
        private String _TipoDoc;
        private String _NumDoc;
        private DateTime _FechaNac;
        private String _EstadoCivil;
        private String _Sexo;
        private byte[] _Foto;
        private bool _Activo;        
        #endregion       

        #region Propiedades
        public Guid NumReferencia
        {
            get { return _NumReferencia; }
            set { _NumReferencia = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public String TipoDoc
        {
            get { return _TipoDoc; }
            set { _TipoDoc = value; }
        }

        public String NumDoc
        {
            get { return _NumDoc; }
            set { _NumDoc = value; }
        }

        public DateTime FechaNac
        {
            get { return _FechaNac; }
            set { _FechaNac = value; }
        }

        public String EstadoCivil
        {
            get { return _EstadoCivil; }
            set { _EstadoCivil = value; }
        }

        public String Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }


        public byte[] Foto
        {
            get { return _Foto; }
            set { _Foto = value; }
        }

        public bool Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }
        #endregion
    } 
        
}
