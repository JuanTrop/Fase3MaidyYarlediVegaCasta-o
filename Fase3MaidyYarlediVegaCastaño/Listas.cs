using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase3MaidyYarlediCastaño.LISTA;

namespace Fase3MaidyYarlediCastaño
{
    public partial class Listas : Form
    {
        ListaEstudiante lista;
        BindingSource binding;

        public Listas()
        {
            lista = new ListaEstudiante();
            binding = new BindingSource();
            InitializeComponent();
            cargarComboEstrato();
            cargarComboPrograma();
            cargarComboSedeUniversidad();
            cargarComboUniversidad();
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;
            btnEliminar.Visible = true;
        }

        private Estudiante cargarEstudiante()
        {
            int id_estudiante = int.Parse(txtId.Text);
            string nombre_estudiante = txtNombre.Text;
            int edad_estudiante = int.Parse(txtEdad.Text);
            int estrato_estudiante = comboEstrato.SelectedIndex;
            string sede_universidad = comboUniversidad.Text;
            string programa_estudiante = comboPrograma.Text;
            string nombre_universidad = comboNUniversidad.Text;
            DateTime fecha = dtFecha.Value;

            Estudiante nuevo_estudiante = new Estudiante(id_estudiante,nombre_estudiante, edad_estudiante, estrato_estudiante, programa_estudiante, sede_universidad, nombre_universidad, fecha);

            return nuevo_estudiante;
        }

        private void cargarGrilla()
        {
            binding = cargarBindingSource();
            if (binding.Count != 0)
            {
                gridInfo.DataSource = new DataGridView();
                gridInfo.DataSource = binding;
                gridInfo.Refresh();
            }
            else
            {
                Estudiante estudiante = new Estudiante();
                binding.Add(estudiante);
                gridInfo.DataSource = binding;

                gridInfo.Refresh();
                this.gridInfo.CurrentCell = null;
                this.gridInfo.Rows[0].Visible = false;
            }
        }

        private void cargarComboEstrato()
        {
            comboEstrato.Items.Add("Seleccione");
            comboEstrato.Items.Add("1");
            comboEstrato.Items.Add("2");
            comboEstrato.Items.Add("3");
            comboEstrato.Items.Add("4");
            comboEstrato.Items.Add("5");
            comboEstrato.Items.Add("6");
            comboEstrato.SelectedIndex = 0;
        }

        private void cargarComboUniversidad()
        {
            comboNUniversidad.Items.Add("Seleccione");
            comboNUniversidad.Items.Add("UNAL");
            comboNUniversidad.Items.Add("UNAD");
            comboNUniversidad.Items.Add("UT");
            comboNUniversidad.Items.Add("UMNG");
            comboNUniversidad.Items.Add("UPTC");
            comboNUniversidad.Items.Add("UCEVA");
            comboNUniversidad.Items.Add("UTCH");
            comboNUniversidad.SelectedIndex = 0;
        }

        private void cargarComboSedeUniversidad()
        {
            comboUniversidad.Items.Add("Seleccione");
            comboUniversidad.Items.Add("Armenia");
            comboUniversidad.Items.Add("Bogotá");
            comboUniversidad.Items.Add("Cartagena");
            comboUniversidad.Items.Add("Cali");
            comboUniversidad.Items.Add("Ibague");
            comboUniversidad.Items.Add("Quibdo");
            comboUniversidad.SelectedIndex = 0;
        }

        private void cargarComboPrograma()
        {
            comboPrograma.Items.Add("Seleccione");
            comboPrograma.Items.Add("Ing. de Sistemas");
            comboPrograma.Items.Add("Ing. Civil");
            comboPrograma.Items.Add("Ing. Quimica");
            comboPrograma.Items.Add("Ing. Alimentos");
            comboPrograma.Items.Add("Ing. Ambiental");
            comboPrograma.Items.Add("Seleccione");
            comboPrograma.SelectedIndex = 0;
        }


        private void cambiarEnfoquePanel()
        {
            pnlGrilla.Visible = !pnlGrilla.Visible;
            pnlDatosCliente.Visible = !pnlDatosCliente.Visible;
        }

        private void cargarCamposNuevo()
        {
            txtNombre.Text = string.Empty;
            txtEdad.Text = string.Empty;
            btnEliminar.Visible = true;
        }

        private void cargarCamposSeleccionado(DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridInfo.Rows[e.RowIndex];
            txtNombre.Text = row.Cells[1].Value.ToString();
            txtEdad.Text = row.Cells[2].Value.ToString();
            comboEstrato.SelectedItem = row.Cells[3].Value.ToString();
            comboPrograma.SelectedItem = row.Cells[4].Value.ToString();
            comboUniversidad.SelectedItem = row.Cells[5].Value.ToString();
            comboNUniversidad.SelectedItem = row.Cells[6].Value.ToString();
            dtFecha.Value = Convert.ToDateTime(row.Cells[7].Value);

            cambiarEnfoquePanel();
        }

        private BindingSource cargarBindingSource()
        {
            BindingSource binding = new BindingSource();

            for(int i = 0; i < lista.contarEstudiantes(); i++)
            {
                binding.Add(lista.ListaEstudiantes[i]);
            }

            return binding;
        }


        private void btnNuevo_Click(object sender, EventArgs e) {
            cargarCamposNuevo();
            cambiarEnfoquePanel();
            btnEliminar.Visible = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Estudiante eliminar = cargarEstudiante();

            lista.eliminarEstudiante(eliminar.Id);
            cargarGrilla();
            cambiarEnfoquePanel();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = cargarEstudiante();
            
            lista.insertarEstudiante(estudiante);
            cargarGrilla();
            cambiarEnfoquePanel();
            btnEliminar.Visible = false;
        }

        private void gridInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cargarCamposNuevo();
            cargarCamposSeleccionado(e);
            btnEliminar.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            cargarCamposNuevo();
            comboEstrato.SelectedIndex = 0;
            comboUniversidad.SelectedIndex = 0;
            comboNUniversidad.SelectedIndex = 0;
            comboPrograma.SelectedIndex = 0;
            cambiarEnfoquePanel();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id_Estudiante = int.Parse(txtId.Text);
            Estudiante nuevos_datos = cargarEstudiante();
            lista.ModificarEstudiante(id_Estudiante, nuevos_datos);
            cargarGrilla(); //Magia
            cambiarEnfoquePanel();
        }
    }
}
