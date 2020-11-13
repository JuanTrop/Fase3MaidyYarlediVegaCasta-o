using System;

namespace Fase3MaidyYarlediCastaño
{
    partial class Listas
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
            this.label4 = new System.Windows.Forms.Label();
            this.pnlGrilla = new System.Windows.Forms.Panel();
            this.gridInfo = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id_ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estrato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sede_universidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destino_Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_control = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pnlDatosCliente = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.labelId = new System.Windows.Forms.Label();
            this.comboPrograma = new System.Windows.Forms.ComboBox();
            this.comboEstrato = new System.Windows.Forms.ComboBox();
            this.comboNUniversidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboUniversidad = new System.Windows.Forms.ComboBox();
            this.lblEstrato = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblReferencia = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.pnlGrilla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).BeginInit();
            this.pnlDatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(92, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(690, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Manejo Estudiantes Beneficiarios Solidaridad Estudiantil";
            // 
            // pnlGrilla
            // 
            this.pnlGrilla.AutoSize = true;
            this.pnlGrilla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGrilla.Controls.Add(this.gridInfo);
            this.pnlGrilla.Controls.Add(this.btnNuevo);
            this.pnlGrilla.Location = new System.Drawing.Point(12, 93);
            this.pnlGrilla.Name = "pnlGrilla";
            this.pnlGrilla.Size = new System.Drawing.Size(870, 311);
            this.pnlGrilla.TabIndex = 14;
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
            this.edad,
            this.Estrato,
            this.Programa,
            this.Sede_universidad,
            this.Destino_Ruta,
            this.Fecha_control});
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
            this.Id_ruta.DataPropertyName = "Nombre";
            this.Id_ruta.HeaderText = "Nombre";
            this.Id_ruta.Name = "Id_ruta";
            this.Id_ruta.ReadOnly = true;
            // 
            // edad
            // 
            this.edad.DataPropertyName = "edad";
            this.edad.HeaderText = "Edad";
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            // 
            // Estrato
            // 
            this.Estrato.DataPropertyName = "Estrato";
            this.Estrato.HeaderText = "Estrato";
            this.Estrato.Name = "Estrato";
            // 
            // Programa
            // 
            this.Programa.DataPropertyName = "Programa";
            this.Programa.HeaderText = "Programa";
            this.Programa.Name = "Programa";
            this.Programa.ReadOnly = true;
            // 
            // Sede_universidad
            // 
            this.Sede_universidad.DataPropertyName = "Sede_universidad";
            this.Sede_universidad.HeaderText = "Sede Universidad";
            this.Sede_universidad.Name = "Sede_universidad";
            this.Sede_universidad.ReadOnly = true;
            // 
            // Destino_Ruta
            // 
            this.Destino_Ruta.DataPropertyName = "Nombre_universidad";
            this.Destino_Ruta.HeaderText = "Nombre Universidad";
            this.Destino_Ruta.Name = "Destino_Ruta";
            this.Destino_Ruta.ReadOnly = true;
            // 
            // Fecha_control
            // 
            this.Fecha_control.DataPropertyName = "Fecha_control";
            this.Fecha_control.HeaderText = "Fecha Control";
            this.Fecha_control.Name = "Fecha_control";
            this.Fecha_control.ReadOnly = true;
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
            // pnlDatosCliente
            // 
            this.pnlDatosCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDatosCliente.Controls.Add(this.btnModificar);
            this.pnlDatosCliente.Controls.Add(this.txtId);
            this.pnlDatosCliente.Controls.Add(this.labelId);
            this.pnlDatosCliente.Controls.Add(this.comboPrograma);
            this.pnlDatosCliente.Controls.Add(this.comboEstrato);
            this.pnlDatosCliente.Controls.Add(this.comboNUniversidad);
            this.pnlDatosCliente.Controls.Add(this.label3);
            this.pnlDatosCliente.Controls.Add(this.dtFecha);
            this.pnlDatosCliente.Controls.Add(this.btnCancelar);
            this.pnlDatosCliente.Controls.Add(this.btnGuardar);
            this.pnlDatosCliente.Controls.Add(this.btnEliminar);
            this.pnlDatosCliente.Controls.Add(this.label2);
            this.pnlDatosCliente.Controls.Add(this.comboUniversidad);
            this.pnlDatosCliente.Controls.Add(this.lblEstrato);
            this.pnlDatosCliente.Controls.Add(this.label1);
            this.pnlDatosCliente.Controls.Add(this.lblReferencia);
            this.pnlDatosCliente.Controls.Add(this.txtEdad);
            this.pnlDatosCliente.Controls.Add(this.labelNombre);
            this.pnlDatosCliente.Controls.Add(this.txtNombre);
            this.pnlDatosCliente.Controls.Add(this.lblId);
            this.pnlDatosCliente.Location = new System.Drawing.Point(25, 93);
            this.pnlDatosCliente.Name = "pnlDatosCliente";
            this.pnlDatosCliente.Size = new System.Drawing.Size(840, 307);
            this.pnlDatosCliente.TabIndex = 15;
            this.pnlDatosCliente.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(157, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 33;
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelId.Location = new System.Drawing.Point(3, 40);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(103, 20);
            this.labelId.TabIndex = 32;
            this.labelId.Text = "Identificacion";
            this.labelId.Click += new System.EventHandler(this.label5_Click);
            // 
            // comboPrograma
            // 
            this.comboPrograma.FormattingEnabled = true;
            this.comboPrograma.Location = new System.Drawing.Point(505, 117);
            this.comboPrograma.Name = "comboPrograma";
            this.comboPrograma.Size = new System.Drawing.Size(267, 21);
            this.comboPrograma.TabIndex = 31;
            // 
            // comboEstrato
            // 
            this.comboEstrato.FormattingEnabled = true;
            this.comboEstrato.Location = new System.Drawing.Point(157, 128);
            this.comboEstrato.Name = "comboEstrato";
            this.comboEstrato.Size = new System.Drawing.Size(100, 21);
            this.comboEstrato.TabIndex = 30;
            // 
            // comboNUniversidad
            // 
            this.comboNUniversidad.FormattingEnabled = true;
            this.comboNUniversidad.Location = new System.Drawing.Point(505, 170);
            this.comboNUniversidad.Name = "comboNUniversidad";
            this.comboNUniversidad.Size = new System.Drawing.Size(267, 21);
            this.comboNUniversidad.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(354, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nombre Universidad";
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(157, 217);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(197, 20);
            this.dtFecha.TabIndex = 27;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancelar.Location = new System.Drawing.Point(402, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 29);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardar.Location = new System.Drawing.Point(303, 257);
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
            this.btnEliminar.Location = new System.Drawing.Point(719, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 29);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(3, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha Control";
            // 
            // comboUniversidad
            // 
            this.comboUniversidad.FormattingEnabled = true;
            this.comboUniversidad.Location = new System.Drawing.Point(157, 168);
            this.comboUniversidad.Name = "comboUniversidad";
            this.comboUniversidad.Size = new System.Drawing.Size(185, 21);
            this.comboUniversidad.TabIndex = 14;
            // 
            // lblEstrato
            // 
            this.lblEstrato.AutoSize = true;
            this.lblEstrato.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrato.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEstrato.Location = new System.Drawing.Point(3, 168);
            this.lblEstrato.Name = "lblEstrato";
            this.lblEstrato.Size = new System.Drawing.Size(134, 20);
            this.lblEstrato.TabIndex = 13;
            this.lblEstrato.Text = "Sede Universidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(354, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Programa";
            // 
            // lblReferencia
            // 
            this.lblReferencia.AutoSize = true;
            this.lblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReferencia.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblReferencia.Location = new System.Drawing.Point(3, 113);
            this.lblReferencia.Name = "lblReferencia";
            this.lblReferencia.Size = new System.Drawing.Size(61, 20);
            this.lblReferencia.TabIndex = 8;
            this.lblReferencia.Text = "Estrato";
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(505, 72);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(134, 20);
            this.txtEdad.TabIndex = 7;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelNombre.Location = new System.Drawing.Point(354, 72);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 20);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Edad";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(157, 82);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblId.Location = new System.Drawing.Point(3, 82);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(146, 20);
            this.lblId.TabIndex = 4;
            this.lblId.Text = "Nombre Estudiante";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificar.Location = new System.Drawing.Point(7, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 29);
            this.btnModificar.TabIndex = 34;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // Listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(894, 414);
            this.Controls.Add(this.pnlDatosCliente);
            this.Controls.Add(this.pnlGrilla);
            this.Controls.Add(this.label4);
            this.Name = "Listas";
            this.Text = "Listas";
            this.pnlGrilla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridInfo)).EndInit();
            this.pnlDatosCliente.ResumeLayout(false);
            this.pnlDatosCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlGrilla;
        private System.Windows.Forms.DataGridView gridInfo;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel pnlDatosCliente;
        private System.Windows.Forms.ComboBox comboNUniversidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboUniversidad;
        private System.Windows.Forms.Label lblEstrato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReferencia;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ComboBox comboPrograma;
        private System.Windows.Forms.ComboBox comboEstrato;
        private EventHandler btnCancelar_Click;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccionar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estrato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sede_universidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destino_Ruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_control;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnModificar;
    }
}