using Fwk.Exceptions;
using Fwk.HelperFunctions;
using Health32David.Backend.Common;
using Health32David.Backend.Common.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health32David.FrontEnd.Forms
{
    public partial class frmCreatePatient : Form
    {

        #region Atributos
        private static ParametrosBEList ListaParametros;        
        #endregion

        #region Constructor
        public frmCreatePatient()
        {
            InitializeComponent();
            ObtenerParametros();
            CargarParametros();
        }        
        #endregion

        #region Metodos
        private ParametrosBEList ObtenerParametros()
        {
            try
            {
                ListaParametros = ServiceCall.BuscarParametros();

            }
            catch (Exception ex)
            {
                string strError = ExceptionHelper.GetAllMessageException(ex);

                MessageBox.Show(strError);
            }
            return ListaParametros;
        }

        public void CargarParametros()
        {
            cmbEstadoCivil.DataSource = ListaParametros.Where(p => p.Tipo_Param == 100).OrderBy(p => p.Nombre).ToList();
            cmbEstadoCivil.DisplayMember = "Nombre";
            cmbEstadoCivil.ValueMember = "Id_Params";

            cmbTipoDocumento.DataSource = ListaParametros.Where(p => p.Tipo_Param == 300).OrderBy(p => p.Nombre).ToList();
            cmbTipoDocumento.DisplayMember = "Nombre";
            cmbTipoDocumento.ValueMember = "Id_Params";
        }

        public bool ValidarCampos()
        {
            errorProviderValidarCampos.Clear();
            bool validate = true;

            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorProviderValidarCampos.SetError(txtNombre, "Por Favor Digite el Nombre");
                validate = false;
            }

            if(string.IsNullOrEmpty(txtApellido.Text))
            {
                errorProviderValidarCampos.SetError(txtApellido, "Por Favor Digite el Apellido");
                validate =  false;
            }

            return validate;

        }

        private bool CrearPaciente()
        {
            PacienteBE NuevoPaciente = new PacienteBE();
            NuevoPaciente.Nombre = txtNombre.Text;
            NuevoPaciente.Apellido = txtApellido.Text;
            NuevoPaciente.TipoDoc = cmbTipoDocumento.SelectedValue.ToString();
            NuevoPaciente.NumDoc = txtDocumento.Text;
            NuevoPaciente.FechaNac = Convert.ToDateTime(dtpFechaNac.Value.ToString("yyyy-MM-dd"));
            NuevoPaciente.EstadoCivil = cmbEstadoCivil.SelectedValue.ToString();
            NuevoPaciente.Sexo = (optHombre.Checked ? 11 : (optMujer.Checked) ? 12 : 13).ToString();
            NuevoPaciente.Foto = TypeFunctions.ConvertImageToByteArray(imgFotoCliente.Image, ImageFormat.Png);            
            NuevoPaciente.Activo = true;         

            var Respuesta = ServiceCall.CrearPaciente(NuevoPaciente);

            if (Respuesta != null)
                return true;
            else
                return false;
        }

        #endregion

        #region Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            if (!CrearPaciente())
            {
                MessageBox.Show("El Paciente no fue creado, contacte al administrador");
                return;
            }
            else
            {
                MessageBox.Show("Paciente Creado con Exito!");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        #endregion

        private void imgFotoCliente_Click(object sender, EventArgs e)
        {
            string imgFileName = FileFunctions.OpenFileDialog_Open(FileFunctions.OpenFilterEnums.OpenImageFilter);
            if (String.IsNullOrEmpty(imgFileName))
                return;
            Image intermedialImage = Image.FromFile(imgFileName);
            if (intermedialImage == null) return;
            imgFotoCliente.Image = Helper.ImageChangeSize(intermedialImage, 200, 250);
        }

    }
}
