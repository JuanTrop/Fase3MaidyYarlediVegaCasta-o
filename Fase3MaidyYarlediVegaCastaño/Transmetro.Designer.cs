namespace Fase3MaidyYarlediCastaño
{
    partial class Transmetro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.cmbDestino = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaRuta = new System.Windows.Forms.DateTimePicker();
            this.texNombreCliente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstrato = new System.Windows.Forms.ComboBox();
            this.lblEstrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtNumBus = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtCodigoRuta = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.gridInfo = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num_bus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.labelConteo = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlDatosCliente.SuspendLayout();
            this.pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pnlDatosCliente);
            this.panel1.Controls.Add(this.pnlGrilla);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(897, 306);
            this.panel1.TabIndex = 0;
            // 
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosCliente.Controls.Add(this.cmbDestino);
            this.pnlDatosCliente.Controls.Add(this.label3);
            this.pnlDatosCliente.Controls.Add(this.dtFechaRuta);
            this.pnlDatosCliente.Controls.Add(this.texNombreCliente);
            this.pnlDatosCliente.Controls.Add(this.btnCancelar);
            this.pnlDatosCliente.Controls.Add(this.btnGuardar);
            this.pnlDatosCliente.Controls.Add(this.btnEliminar);
            this.pnlDatosCliente.Controls.Add(this.label2);
            this.pnlDatosCliente.Controls.Add(this.cmbEstrato);
            this.pnlDatosCliente.Controls.Add(this.lblEstrato);
            this.pnlDatosCliente.Controls.Add(this.label1);
            this.pnlDatosCliente.Controls.Add(this.txtIdCliente);
            this.pnlDatosCliente.Controls.Add(this.lblReferencia);
            this.pnlDatosCliente.Controls.Add(this.txtNumBus);
            this.pnlDatosCliente.Controls.Add(this.labelNombre);
            this.pnlDatosCliente.Controls.Add(this.txtCodigoRuta);
            this.pnlDatosCliente.Controls.Add(this.lblId);
            this.pnlDatosCliente.Location = new System.Drawing.Point(38, 17);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(814, 286);
            this.pnlDatosCliente.TabIndex = 11;
            this.pnlDatosCliente.Visible = false;
            // 
            // cmbDestino
            // 
            this.cmbDestino.FormattingEnabled = true;
            this.cmbDestino.Location = new System.Drawing.Point(458, 155);
            this.cmbDestino.Name = "cmbDestino";
            this.cmbDestino.Size = new System.Drawing.Size(185, 21);
            this.cmbDestino.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(334, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Destino Ruta";
            // 
            // dtFechaRuta
            // 
            this.dtFechaRuta.Location = new System.Drawing.Point(137, 202);
            this.dtFechaRuta.Name = "dtFechaRuta";
            this.dtFechaRuta.Size = new System.Drawing.Size(197, 20);
            this.dtFechaRuta.TabIndex = 27;
            // 
            // texNombreCliente
            // 
            this.texNombreCliente.Location = new System.Drawing.Point(458, 103);
            this.texNombreCliente.Name = "texNombreCliente";
            this.texNombreCliente.Size = new System.Drawing.Size(334, 20);
            this.texNombreCliente.TabIndex = 26;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(402, 242);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 29);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(303, 242);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 29);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(687, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 29);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Visible = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(27, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Ruta";
            // 
            // cmbEstrato
            // 
            this.cmbEstrato.FormattingEnabled = true;
            this.cmbEstrato.Location = new System.Drawing.Point(137, 153);
            this.cmbEstrato.Name = "cmbEstrato";
            this.cmbEstrato.Size = new System.Drawing.Size(185, 21);
            this.cmbEstrato.TabIndex = 14;
            // 
            // lblEstrato
            // 
            this.lblEstrato.AutoSize = true;
            this.lblEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrato.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstrato.Location = new System.Drawing.Point(28, 153);
            this.lblEstrato.Name = "lblEstrato";
            this.lblEstrato.Size = new System.Drawing.Size(104, 20);
            this.lblEstrato.TabIndex = 13;
            this.lblEstrato.Text = "Nombre Ruta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(334, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre Cliente";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(137, 105);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(100, 20);
            this.txtIdCliente.TabIndex = 9;
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReferencia.Location = new System.Drawing.Point(28, 105);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(76, 20);
            this.lblReferencia.TabIndex = 8;
            this.lblReferencia.Text = "Id Cliente";
            // 
            // txtNumBus
            // 
            this.txtNumBus.Location = new System.Drawing.Point(458, 57);
            this.txtNumBus.Name = "txtNumBus";
            this.txtNumBus.Size = new System.Drawing.Size(134, 20);
            this.txtNumBus.TabIndex = 7;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombre.Location = new System.Drawing.Point(334, 57);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(97, 20);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Numero Bus";
            // 
            // txtCodigoRuta
            // 
            this.txtCodigoRuta.Location = new System.Drawing.Point(137, 57);
            this.txtCodigoRuta.Name = "txtCodigoRuta";
            this.txtCodigoRuta.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoRuta.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblId.Location = new System.Drawing.Point(22, 55);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(98, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Codigo Ruta";
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.AutoSize = true;
            this.pnlGrilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrilla.Controls.Add(this.gridInfo);
            this.pnlGrilla.Controls.Add(this.btnNuevo);
            this.pnlGrilla.Location = new System.Drawing.Point(8, 17);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(870, 227);
            this.pnlGrilla.TabIndex = 10;
            // 
            // gridInfo
            // 
            this.gridInfo.AllowUserToAddRows = false;
            this.gridInfo.AllowUserToDeleteRows = false;
            this.gridInfo.AllowUserToResizeColumns = false;
            this.gridInfo.AllowUserToResizeRows = false;
            this.gridInfo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gridInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar,
            this.Id_ruta,
            this.Num_bus,
            this.Id_Cliente,
            this.Nombre_cliente,
            this.Nombre_ruta,
            this.Destino_Ruta,
            this.Fecha_Ruta});
            this.gridInfo.GridColor = System.Drawing.SystemColors.Highlight;
            this.gridInfo.Location = new System.Drawing.Point(6, 72);
            this.gridInfo.Name = "gridInfo";
            this.gridInfo.Size = new System.Drawing.Size(852, 150);
            this.gridInfo.TabIndex = 24;
            this.gridInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridInfo_CellContentClick);
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "";
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Seleccionar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccionar.Text = "Seleccionar";
            this.Seleccionar.UseColumnTextForButtonValue = true;
            // 
            // Id_ruta
            // 
            this.Id_ruta.DataPropertyName = "Id_ruta";
            this.Id_ruta.HeaderText = "Id Ruta";
            this.Id_ruta.Name = "Id_ruta";
            this.Id_ruta.ReadOnly = true;
            // 
            // Num_bus
            // 
            this.Num_bus.DataPropertyName = "Num_bus";
            this.Num_bus.HeaderText = "No. Bus";
            this.Num_bus.Name = "Num_bus";
            this.Num_bus.ReadOnly = true;
            // 
            // Id_Cliente
            // 
            this.Id_Cliente.DataPropertyName = "Id_Cliente";
            this.Id_Cliente.HeaderText = "Id Cliente";
            this.Id_Cliente.Name = "Id_Cliente";
            // 
            // Nombre_cliente
            // 
            this.Nombre_cliente.DataPropertyName = "Nombre_cliente";
            this.Nombre_cliente.HeaderText = "Nombre Cliente";
            this.Nombre_cliente.Name = "Nombre_cliente";
            this.Nombre_cliente.ReadOnly = true;
            // 
            // Nombre_ruta
            // 
            this.Nombre_ruta.DataPropertyName = "Nombre_ruta";
            this.Nombre_ruta.HeaderText = "Nombre Ruta";
            this.Nombre_ruta.Name = "Nombre_ruta";
            this.Nombre_ruta.ReadOnly = true;
            // 
            // Destino_Ruta
            // 
            this.Destino_Ruta.DataPropertyName = "Destino_Ruta";
            this.Destino_Ruta.HeaderText = "Destino Ruta";
            this.Destino_Ruta.Name = "Destino_Ruta";
            this.Destino_Ruta.ReadOnly = true;
            // 
            // Fecha_Ruta
            // 
            this.Fecha_Ruta.DataPropertyName = "Fecha_Ruta";
            this.Fecha_Ruta.HeaderText = "Fecha Ruta";
            this.Fecha_Ruta.Name = "Fecha_Ruta";
            this.Fecha_Ruta.ReadOnly = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNuevo.Location = new System.Drawing.Point(771, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 29);
            this.btnNuevo.TabIndex = 23;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(183, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(563, 51);
            this.label4.TabIndex = 12;
            this.label4.Text = "Manejo Clientes Transmetro";
            // 
            // labelConteo
            // 
            this.labelConteo.AutoSize = true;
            this.labelConteo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConteo.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelConteo.Location = new System.Drawing.Point(654, 399);
            this.labelConteo.Name = "labelConteo";
            this.labelConteo.Size = new System.Drawing.Size(160, 20);
            this.labelConteo.TabIndex = 13;
            this.labelConteo.Text = "Cantidad de registros";
            this.labelConteo.Click += new System.EventHandler(this.label5_Click);
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidad.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelCantidad.Location = new System.Drawing.Point(846, 399);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(18, 20);
            this.labelCantidad.TabIndex = 14;
            this.labelCantidad.Text = "0";
            // 
            // Transmetro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(947, 428);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.labelConteo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Transmetro";
            this.Text = "Colas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.DataGridView gridInfo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlDatosCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstrato;
        private System.Windows.Forms.Label lblEstrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtNumBus;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtCodigoRuta;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox texNombreCliente;
        private System.Windows.Forms.DateTimePicker dtFechaRuta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbDestino;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num_bus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino_Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Ruta;
        private System.Windows.Forms.Label labelConteo;
        private System.Windows.Forms.Label labelCantidad;
    }
}