using Fwk.Bases;
using System;

namespace Health32David.Backend.Common
{
    public class ParametrosBEList : BaseEntities<ParametrosBE> { }
    public class ParametrosBE : BaseEntity
    {
        #region Atributos
        private Int32 _Id_Params;
        private String _Nombre;
        private String _Descripcion;
        private Int32 _Tipo_Param;        
        #endregion

        #region Propiedades
        public Int32 Id_Params
        {
            get { return _Id_Params; }
            set { _Id_Params = value; }
        }

        public String Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public String Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }

        public Int32 Tipo_Param
        {
            get { return _Tipo_Param; }
            set { _Tipo_Param = value; }
        }        
        #endregion        
    }
}
