namespace Health32David.FrontEnd.Forms
{
    partial class frmCreatePatient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreatePatient));
            this.lblTitleCreatePatient = new System.Windows.Forms.Label();
            this.ctlTabCreatePatient = new System.Windows.Forms.TabControl();
            this.tabPagePatient = new System.Windows.Forms.TabPage();
            this.groupBoxSex = new System.Windows.Forms.GroupBox();
            this.optMujer = new System.Windows.Forms.RadioButton();
            this.optHombre = new System.Windows.Forms.RadioButton();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbEstadoCivil = new System.Windows.Forms.ComboBox();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumRefPatient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.errorProviderValidarCampos = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.imgFotoCliente = new System.Windows.Forms.PictureBox();
            this.ctlTabCreatePatient.SuspendLayout();
            this.tabPagePatient.SuspendLayout();
            this.groupBoxSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidarCampos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleCreatePatient
            // 
            this.lblTitleCreatePatient.AutoSize = true;
            this.lblTitleCreatePatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCreatePatient.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitleCreatePatient.Location = new System.Drawing.Point(12, 9);
            this.lblTitleCreatePatient.Name = "lblTitleCreatePatient";
            this.lblTitleCreatePatient.Size = new System.Drawing.Size(290, 42);
            this.lblTitleCreatePatient.TabIndex = 0;
            this.lblTitleCreatePatient.Text = "Alta de Paciente";
            // 
            // ctlTabCreatePatient
            // 
            this.ctlTabCreatePatient.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.ctlTabCreatePatient.Controls.Add(this.tabPagePatient);
            this.ctlTabCreatePatient.Controls.Add(this.tabPage2);
            this.ctlTabCreatePatient.Location = new System.Drawing.Point(12, 69);
            this.ctlTabCreatePatient.Name = "ctlTabCreatePatient";
            this.ctlTabCreatePatient.SelectedIndex = 0;
            this.ctlTabCreatePatient.Size = new System.Drawing.Size(931, 450);
            this.ctlTabCreatePatient.TabIndex = 1;
            // 
            // tabPagePatient
            // 
            this.tabPagePatient.Controls.Add(this.btnCancelar);
            this.tabPagePatient.Controls.Add(this.btnGuardar);
            this.tabPagePatient.Controls.Add(this.imgFotoCliente);
            this.tabPagePatient.Controls.Add(this.groupBoxSex);
            this.tabPagePatient.Controls.Add(this.dtpFechaNac);
            this.tabPagePatient.Controls.Add(this.cmbEstadoCivil);
            this.tabPagePatient.Controls.Add(this.cmbTipoDocumento);
            this.tabPagePatient.Controls.Add(this.txtDocumento);
            this.tabPagePatient.Controls.Add(this.txtApellido);
            this.tabPagePatient.Controls.Add(this.txtNombre);
            this.tabPagePatient.Controls.Add(this.lblEstadoCivil);
            this.tabPagePatient.Controls.Add(this.label5);
            this.tabPagePatient.Controls.Add(this.lblDocumento);
            this.tabPagePatient.Controls.Add(this.btnBuscar);
            this.tabPagePatient.Controls.Add(this.lblApellido);
            this.tabPagePatient.Controls.Add(this.lblName);
            this.tabPagePatient.Controls.Add(this.txtNumRefPatient);
            this.tabPagePatient.Controls.Add(this.label1);
            this.tabPagePatient.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPagePatient.Location = new System.Drawing.Point(4, 25);
            this.tabPagePatient.Name = "tabPagePatient";
            this.tabPagePatient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatient.Size = new System.Drawing.Size(923, 421);
            this.tabPagePatient.TabIndex = 0;
            this.tabPagePatient.Text = "Paciente";
            this.tabPagePatient.UseVisualStyleBackColor = true;
            // 
            // groupBoxSex
            // 
            this.groupBoxSex.Controls.Add(this.optMujer);
            this.groupBoxSex.Controls.Add(this.optHombre);
            this.groupBoxSex.Location = new System.Drawing.Point(49, 306);
            this.groupBoxSex.Name = "groupBoxSex";
            this.groupBoxSex.Size = new System.Drawing.Size(178, 48);
            this.groupBoxSex.TabIndex = 16;
            this.groupBoxSex.TabStop = false;
            // 
            // optMujer
            // 
            this.optMujer.AutoSize = true;
            this.optMujer.Location = new System.Drawing.Point(99, 15);
            this.optMujer.Name = "optMujer";
            this.optMujer.Size = new System.Drawing.Size(68, 22);
            this.optMujer.TabIndex = 1;
            this.optMujer.TabStop = true;
            this.optMujer.Text = "Mujer";
            this.optMujer.UseVisualStyleBackColor = true;
            // 
            // optHombre
            // 
            this.optHombre.AutoSize = true;
            this.optHombre.Location = new System.Drawing.Point(7, 15);
            this.optHombre.Name = "optHombre";
            this.optHombre.Size = new System.Drawing.Size(86, 22);
            this.optHombre.TabIndex = 0;
            this.optHombre.TabStop = true;
            this.optHombre.Text = "Hombre";
            this.optHombre.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Location = new System.Drawing.Point(467, 257);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(306, 26);
            this.dtpFechaNac.TabIndex = 14;
            // 
            // cmbEstadoCivil
            // 
            this.cmbEstadoCivil.FormattingEnabled = true;
            this.cmbEstadoCivil.Location = new System.Drawing.Point(467, 313);
            this.cmbEstadoCivil.Name = "cmbEstadoCivil";
            this.cmbEstadoCivil.Size = new System.Drawing.Size(201, 26);
            this.cmbEstadoCivil.TabIndex = 13;
            this.cmbEstadoCivil.Text = "Seleccione Estado Civil";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(467, 199);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(67, 26);
            this.cmbTipoDocumento.TabIndex = 11;
            this.cmbTipoDocumento.Text = "Seleccione Tipo de Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(549, 199);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(211, 26);
            this.txtDocumento.TabIndex = 10;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(467, 131);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(293, 26);
            this.txtApellido.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(467, 79);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(293, 26);
            this.txtNombre.TabIndex = 8;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(315, 316);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(93, 18);
            this.lblEstadoCivil.TabIndex = 7;
            this.lblEstadoCivil.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(315, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Fecha Nacimiento";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(315, 202);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(95, 18);
            this.lblDocumento.TabIndex = 5;
            this.lblDocumento.Text = "Documento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscar.Location = new System.Drawing.Point(49, 69);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(178, 39);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Existente";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(315, 139);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(64, 18);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "Apellido";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(315, 79);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 18);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Nombre";
            // 
            // txtNumRefPatient
            // 
            this.txtNumRefPatient.Location = new System.Drawing.Point(467, 16);
            this.txtNumRefPatient.Name = "txtNumRefPatient";
            this.txtNumRefPatient.Size = new System.Drawing.Size(366, 26);
            this.txtNumRefPatient.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de Referencia Obligatoriamente Único";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(923, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // errorProviderValidarCampos
            // 
            this.errorProviderValidarCampos.ContainerControl = this;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Health32David.FrontEnd.Properties.Resources.if_Delete_132192;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(655, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 39);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Health32David.FrontEnd.Properties.Resources._001_59;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(454, 376);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 39);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // imgFotoCliente
            // 
            this.imgFotoCliente.BackgroundImage = global::Health32David.FrontEnd.Properties.Resources.PhotoIcon2;
            this.imgFotoCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgFotoCliente.Location = new System.Drawing.Point(45, 114);
            this.imgFotoCliente.Name = "imgFotoCliente";
            this.imgFotoCliente.Size = new System.Drawing.Size(176, 186);
            this.imgFotoCliente.TabIndex = 17;
            this.imgFotoCliente.TabStop = false;
            this.imgFotoCliente.Click += new System.EventHandler(this.imgFotoCliente_Click);
            // 
            // frmCreatePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 547);
            this.Controls.Add(this.ctlTabCreatePatient);
            this.Controls.Add(this.lblTitleCreatePatient);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCreatePatient";
            this.Text = "frmCreatePatient";
            this.ctlTabCreatePatient.ResumeLayout(false);
            this.tabPagePatient.ResumeLayout(false);
            this.tabPagePatient.PerformLayout();
            this.groupBoxSex.ResumeLayout(false);
            this.groupBoxSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidarCampos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFotoCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCreatePatient;
        private System.Windows.Forms.TabControl ctlTabCreatePatient;
        private System.Windows.Forms.TabPage tabPagePatient;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumRefPatient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cmbEstadoCivil;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox groupBoxSex;
        private System.Windows.Forms.RadioButton optMujer;
        private System.Windows.Forms.RadioButton optHombre;
        private System.Windows.Forms.PictureBox imgFotoCliente;
        private System.Windows.Forms.ErrorProvider errorProviderValidarCampos;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}