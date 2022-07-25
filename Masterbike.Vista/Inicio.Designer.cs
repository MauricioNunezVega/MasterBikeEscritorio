
namespace Masterbike.Vista
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.lblErrorTipoConvenio = new System.Windows.Forms.Label();
            this.lblErrorRuta = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.lsbLista = new System.Windows.Forms.ListBox();
            this.gbxSeleccionConvenio = new System.Windows.Forms.GroupBox();
            this.rbClubDeportivo = new System.Windows.Forms.RadioButton();
            this.rbMunicipalidad = new System.Windows.Forms.RadioButton();
            this.rbEmpresa = new System.Windows.Forms.RadioButton();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnCerraSesion = new System.Windows.Forms.Button();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.gbxSeparador = new System.Windows.Forms.GroupBox();
            this.rbComa = new System.Windows.Forms.RadioButton();
            this.rbPuntoComa = new System.Windows.Forms.RadioButton();
            this.rbEspacio = new System.Windows.Forms.RadioButton();
            this.lblErrorSeparador = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            this.gbxSeleccionConvenio.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.gbxSeparador.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(433, 422);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(894, 520);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.Window;
            this.panelFormularios.Controls.Add(this.lblErrorSeparador);
            this.panelFormularios.Controls.Add(this.gbxSeparador);
            this.panelFormularios.Controls.Add(this.lblErrorTipoConvenio);
            this.panelFormularios.Controls.Add(this.lblErrorRuta);
            this.panelFormularios.Controls.Add(this.lblLista);
            this.panelFormularios.Controls.Add(this.lsbLista);
            this.panelFormularios.Controls.Add(this.gbxSeleccionConvenio);
            this.panelFormularios.Controls.Add(this.btnCargar);
            this.panelFormularios.Controls.Add(this.txtRuta);
            this.panelFormularios.Controls.Add(this.btnSeleccionar);
            this.panelFormularios.Controls.Add(this.label2);
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(164, 32);
            this.panelFormularios.Margin = new System.Windows.Forms.Padding(2);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(730, 488);
            this.panelFormularios.TabIndex = 0;
            // 
            // lblErrorTipoConvenio
            // 
            this.lblErrorTipoConvenio.AutoSize = true;
            this.lblErrorTipoConvenio.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorTipoConvenio.Location = new System.Drawing.Point(17, 201);
            this.lblErrorTipoConvenio.Name = "lblErrorTipoConvenio";
            this.lblErrorTipoConvenio.Size = new System.Drawing.Size(372, 13);
            this.lblErrorTipoConvenio.TabIndex = 11;
            this.lblErrorTipoConvenio.Text = "Debe seleccionar el tipo de convenio que se aplicará a los clientes de la lista.";
            this.lblErrorTipoConvenio.Visible = false;
            // 
            // lblErrorRuta
            // 
            this.lblErrorRuta.AutoSize = true;
            this.lblErrorRuta.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorRuta.Location = new System.Drawing.Point(148, 129);
            this.lblErrorRuta.Name = "lblErrorRuta";
            this.lblErrorRuta.Size = new System.Drawing.Size(239, 13);
            this.lblErrorRuta.TabIndex = 10;
            this.lblErrorRuta.Text = "Debe seleccionar un archivo plano de su equipo.";
            this.lblErrorRuta.Visible = false;
            // 
            // lblLista
            // 
            this.lblLista.AutoSize = true;
            this.lblLista.Location = new System.Drawing.Point(17, 310);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(255, 13);
            this.lblLista.TabIndex = 9;
            this.lblLista.Text = "Lista de e-mail de usuarios del archivo seleccionado:";
            // 
            // lsbLista
            // 
            this.lsbLista.FormattingEnabled = true;
            this.lsbLista.Items.AddRange(new object[] {
            "Aún no se ha seleccionado un archivo plano en su equipo."});
            this.lsbLista.Location = new System.Drawing.Point(20, 328);
            this.lsbLista.Name = "lsbLista";
            this.lsbLista.Size = new System.Drawing.Size(623, 121);
            this.lsbLista.TabIndex = 8;
            // 
            // gbxSeleccionConvenio
            // 
            this.gbxSeleccionConvenio.Controls.Add(this.rbClubDeportivo);
            this.gbxSeleccionConvenio.Controls.Add(this.rbMunicipalidad);
            this.gbxSeleccionConvenio.Controls.Add(this.rbEmpresa);
            this.gbxSeleccionConvenio.Location = new System.Drawing.Point(20, 149);
            this.gbxSeleccionConvenio.Name = "gbxSeleccionConvenio";
            this.gbxSeleccionConvenio.Size = new System.Drawing.Size(623, 49);
            this.gbxSeleccionConvenio.TabIndex = 7;
            this.gbxSeleccionConvenio.TabStop = false;
            this.gbxSeleccionConvenio.Text = "Seleccione el tipo de convenio:";
            // 
            // rbClubDeportivo
            // 
            this.rbClubDeportivo.AutoSize = true;
            this.rbClubDeportivo.Location = new System.Drawing.Point(257, 19);
            this.rbClubDeportivo.Name = "rbClubDeportivo";
            this.rbClubDeportivo.Size = new System.Drawing.Size(95, 17);
            this.rbClubDeportivo.TabIndex = 8;
            this.rbClubDeportivo.TabStop = true;
            this.rbClubDeportivo.Text = "Club Deportivo";
            this.rbClubDeportivo.UseVisualStyleBackColor = true;
            this.rbClubDeportivo.CheckedChanged += new System.EventHandler(this.rbClubDeportivo_CheckedChanged);
            // 
            // rbMunicipalidad
            // 
            this.rbMunicipalidad.AutoSize = true;
            this.rbMunicipalidad.Location = new System.Drawing.Point(128, 19);
            this.rbMunicipalidad.Name = "rbMunicipalidad";
            this.rbMunicipalidad.Size = new System.Drawing.Size(90, 17);
            this.rbMunicipalidad.TabIndex = 7;
            this.rbMunicipalidad.TabStop = true;
            this.rbMunicipalidad.Text = "Municipalidad";
            this.rbMunicipalidad.UseVisualStyleBackColor = true;
            this.rbMunicipalidad.CheckedChanged += new System.EventHandler(this.rbMunicipalidad_CheckedChanged);
            // 
            // rbEmpresa
            // 
            this.rbEmpresa.AutoSize = true;
            this.rbEmpresa.Location = new System.Drawing.Point(6, 19);
            this.rbEmpresa.Name = "rbEmpresa";
            this.rbEmpresa.Size = new System.Drawing.Size(66, 17);
            this.rbEmpresa.TabIndex = 6;
            this.rbEmpresa.TabStop = true;
            this.rbEmpresa.Text = "Empresa";
            this.rbEmpresa.UseVisualStyleBackColor = true;
            this.rbEmpresa.CheckedChanged += new System.EventHandler(this.rbEmpresa_CheckedChanged);
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCargar.ForeColor = System.Drawing.Color.White;
            this.btnCargar.Location = new System.Drawing.Point(20, 453);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(122, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar archivo";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(148, 102);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.ReadOnly = true;
            this.txtRuta.Size = new System.Drawing.Size(495, 20);
            this.txtRuta.TabIndex = 3;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnSeleccionar.FlatAppearance.BorderSize = 0;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
            this.btnSeleccionar.Location = new System.Drawing.Point(20, 100);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(122, 23);
            this.btnSeleccionar.TabIndex = 2;
            this.btnSeleccionar.Text = "Seleccionar archivo";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(17, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione un archivo plano de su equipo para cargar los datos a la base de datos" +
    " de MasterBike";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE ESCRITORIO DE MASTERBIKE";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(40)))), ((int)(((byte)(51)))));
            this.panelMenu.Controls.Add(this.lblApellido);
            this.panelMenu.Controls.Add(this.lblNombreUsuario);
            this.panelMenu.Controls.Add(this.btnCerraSesion);
            this.panelMenu.Controls.Add(this.lblConvenio);
            this.panelMenu.Controls.Add(this.lblBienvenido);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 32);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(164, 488);
            this.panelMenu.TabIndex = 1;
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.White;
            this.lblNombreUsuario.Location = new System.Drawing.Point(6, 100);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(35, 13);
            this.lblNombreUsuario.TabIndex = 8;
            this.lblNombreUsuario.Text = "label3";
            // 
            // btnCerraSesion
            // 
            this.btnCerraSesion.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnCerraSesion.FlatAppearance.BorderSize = 0;
            this.btnCerraSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnCerraSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.btnCerraSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerraSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerraSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerraSesion.Location = new System.Drawing.Point(2, 417);
            this.btnCerraSesion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerraSesion.Name = "btnCerraSesion";
            this.btnCerraSesion.Size = new System.Drawing.Size(269, 32);
            this.btnCerraSesion.TabIndex = 7;
            this.btnCerraSesion.Text = "Cerrar Sesión";
            this.btnCerraSesion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerraSesion.UseVisualStyleBackColor = false;
            this.btnCerraSesion.Click += new System.EventHandler(this.btnCerraSesion_Click);
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblConvenio.Location = new System.Drawing.Point(13, 463);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(0, 13);
            this.lblConvenio.TabIndex = 5;
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblBienvenido.ForeColor = System.Drawing.Color.White;
            this.lblBienvenido.Location = new System.Drawing.Point(6, 78);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(80, 15);
            this.lblBienvenido.TabIndex = 4;
            this.lblBienvenido.Text = "BIENVENIDO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(93)))), ((int)(((byte)(142)))));
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Margin = new System.Windows.Forms.Padding(2);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(894, 32);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(840, 8);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(21, 21);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(840, 8);
            this.btnRestaurar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(21, 21);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(815, 8);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(21, 21);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(866, 8);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 21);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // gbxSeparador
            // 
            this.gbxSeparador.Controls.Add(this.rbEspacio);
            this.gbxSeparador.Controls.Add(this.rbPuntoComa);
            this.gbxSeparador.Controls.Add(this.rbComa);
            this.gbxSeparador.Location = new System.Drawing.Point(20, 234);
            this.gbxSeparador.Name = "gbxSeparador";
            this.gbxSeparador.Size = new System.Drawing.Size(623, 45);
            this.gbxSeparador.TabIndex = 12;
            this.gbxSeparador.TabStop = false;
            this.gbxSeparador.Text = "Opciones de separador:";
            // 
            // rbComa
            // 
            this.rbComa.AutoSize = true;
            this.rbComa.Location = new System.Drawing.Point(7, 20);
            this.rbComa.Name = "rbComa";
            this.rbComa.Size = new System.Drawing.Size(64, 17);
            this.rbComa.TabIndex = 0;
            this.rbComa.TabStop = true;
            this.rbComa.Text = "Coma (,)";
            this.rbComa.UseVisualStyleBackColor = true;
            this.rbComa.CheckedChanged += new System.EventHandler(this.rbComa_CheckedChanged);
            // 
            // rbPuntoComa
            // 
            this.rbPuntoComa.AutoSize = true;
            this.rbPuntoComa.Location = new System.Drawing.Point(131, 20);
            this.rbPuntoComa.Name = "rbPuntoComa";
            this.rbPuntoComa.Size = new System.Drawing.Size(102, 17);
            this.rbPuntoComa.TabIndex = 1;
            this.rbPuntoComa.TabStop = true;
            this.rbPuntoComa.Text = "Punto y coma (;)";
            this.rbPuntoComa.UseVisualStyleBackColor = true;
            this.rbPuntoComa.CheckedChanged += new System.EventHandler(this.rbPuntoComa_CheckedChanged);
            // 
            // rbEspacio
            // 
            this.rbEspacio.AutoSize = true;
            this.rbEspacio.Location = new System.Drawing.Point(266, 19);
            this.rbEspacio.Name = "rbEspacio";
            this.rbEspacio.Size = new System.Drawing.Size(63, 17);
            this.rbEspacio.TabIndex = 2;
            this.rbEspacio.TabStop = true;
            this.rbEspacio.Text = "Espacio";
            this.rbEspacio.UseVisualStyleBackColor = true;
            this.rbEspacio.CheckedChanged += new System.EventHandler(this.rbEspacio_CheckedChanged);
            // 
            // lblErrorSeparador
            // 
            this.lblErrorSeparador.AutoSize = true;
            this.lblErrorSeparador.ForeColor = System.Drawing.Color.DarkRed;
            this.lblErrorSeparador.Location = new System.Drawing.Point(23, 282);
            this.lblErrorSeparador.Name = "lblErrorSeparador";
            this.lblErrorSeparador.Size = new System.Drawing.Size(328, 13);
            this.lblErrorSeparador.TabIndex = 13;
            this.lblErrorSeparador.Text = "Debe seleccionar el tipo de seperador de campos del archivo plano.";
            this.lblErrorSeparador.Visible = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.Color.White;
            this.lblApellido.Location = new System.Drawing.Point(6, 116);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(35, 13);
            this.lblApellido.TabIndex = 9;
            this.lblApellido.Text = "label3";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(247)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(894, 520);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Inicio";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            this.gbxSeleccionConvenio.ResumeLayout(false);
            this.gbxSeleccionConvenio.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.gbxSeparador.ResumeLayout(false);
            this.gbxSeparador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerraSesion;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtRuta;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.GroupBox gbxSeleccionConvenio;
        private System.Windows.Forms.RadioButton rbClubDeportivo;
        private System.Windows.Forms.RadioButton rbMunicipalidad;
        private System.Windows.Forms.RadioButton rbEmpresa;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.ListBox lsbLista;
        private System.Windows.Forms.Label lblErrorTipoConvenio;
        private System.Windows.Forms.Label lblErrorRuta;
        private System.Windows.Forms.Label lblErrorSeparador;
        private System.Windows.Forms.GroupBox gbxSeparador;
        private System.Windows.Forms.RadioButton rbEspacio;
        private System.Windows.Forms.RadioButton rbPuntoComa;
        private System.Windows.Forms.RadioButton rbComa;
        private System.Windows.Forms.Label lblApellido;
    }
}