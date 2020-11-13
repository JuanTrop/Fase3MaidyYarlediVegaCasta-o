using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase3MaidyYarlediCastaño.COLA;


namespace Fase3MaidyYarlediCastaño
{
    public partial class Transmetro : Form
    {
        private ColaTransmetro cola;
        BindingSource bindingSource1;
        public Transmetro()
        {
            InitializeComponent();
            CargarRutas();
            CargarDestinos();
            cola = new ColaTransmetro();
            bindingSource1 = new BindingSource();
        }

        private void CargarDestinos()
        {
            cmbDestino.Items.Add("Seleccione");
            cmbDestino.Items.Add("Usaquén");
            cmbDestino.Items.Add("Suba");
            cmbDestino.Items.Add("Teusaquillo");
            cmbDestino.Items.Add("Fontibón");
            cmbDestino.Items.Add("Kennedy");
            cmbDestino.SelectedIndex = 0;
        }

        private void CargarRutas()
        {
            cmbEstrato.Items.Add( "Seleccione");
            cmbEstrato.Items.Add("Ruta 1");
            cmbEstrato.Items.Add("Ruta 2");
            cmbEstrato.Items.Add("Ruta 3");
            cmbEstrato.Items.Add("Ruta 4");
            cmbEstrato.Items.Add("Ruta 5");
            cmbEstrato.SelectedIndex = 0;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            pnlGrilla.Visible = false;
            pnlDatosCliente.Visible = true;
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtCodigoRuta.Text = string.Empty;
            txtNumBus.Text = string.Empty;
            txtIdCliente.Text = string.Empty;
            texNombreCliente.Text = string.Empty;
            cmbEstrato.SelectedIndex = 0;
            dtFechaRuta.Value = DateTime.Now;
            btnModificar.Visible = true;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            cola.EliminarPasajeroBusqueda(Convert.ToInt32(txtCodigoRuta.Text));
            bindingSource1 = cargarBindingSource();


            if (bindingSource1.Count != 0)
            {
                gridInfo.DataSource = bindingSource1;
                gridInfo.Refresh();
            }
            else
            {
                /* bindingSource1 = new BindingSource();
                 gridInfo.DataSource = bindingSource1;
                 gridInfo.Refresh();*/
                Cliente elemento = new Cliente();
                bindingSource1.Add(elemento);
                gridInfo.DataSource = bindingSource1;

                gridInfo.Refresh();
                this.gridInfo.CurrentCell = null;
                this.gridInfo.Rows[0].Visible = false;
                pnlDatosCliente.Visible = false;
            }

            labelCantidad.Text = cola.contarClientes().ToString();
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;


        }

        private BindingSource cargarBindingSource()
        {
            //Reemplazar con el atributo cola
            Queue<Cliente> copy = new Queue<Cliente>();
            BindingSource bindingSource1 = new BindingSource();
            if (cola.ColaTransmet.Count > 0)
            {
                for (int i = 0; i <= cola.ColaTransmet.Count; i++)
                {
                    Cliente elemento = cola.ColaTransmet.Dequeue();
                    bindingSource1.Add(elemento);
                    copy.Enqueue(elemento);
                }

                cola.ColaTransmet = copy;
            }
            return bindingSource1;
        }

        public Cliente cargarCliente()
        {
            int id_ruta = int.Parse(txtCodigoRuta.Text);
            int no_Bus = int.Parse(txtNumBus.Text);
            int id_cliente = Convert.ToInt32(txtIdCliente.Text);
            string nombre = texNombreCliente.Text;
            string nombreRuta = cmbEstrato.SelectedItem.ToString();
            DateTime fecha = dtFechaRuta.Value;
            string destino_Ruta = cmbDestino.SelectedItem.ToString();


            Cliente cliente = new Cliente(id_ruta, no_Bus, id_cliente, nombre, nombreRuta, destino_Ruta, fecha);
            return cliente;
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id_ruta = int.Parse(txtCodigoRuta.Text);
            int no_Bus = int.Parse(txtNumBus.Text);
            int id_cliente = Convert.ToInt32(txtIdCliente.Text);
            string nombre = texNombreCliente.Text;
            string nombreRuta = cmbEstrato.SelectedItem.ToString();
            DateTime fecha = dtFechaRuta.Value;
            string destino_Ruta = cmbDestino.SelectedItem.ToString();


            Cliente cliente = new Cliente(id_ruta, no_Bus, id_cliente, nombre, nombreRuta, destino_Ruta, fecha);
            this.cola.ingresarPasajero(cliente);
            //bindingSource1.Add(pila.StackFacturas.Peek());
            bindingSource1 = cargarBindingSource();
            gridInfo.DataSource = new DataGridView();
            gridInfo.DataSource = bindingSource1;
            gridInfo.Refresh();


            labelCantidad.Text = cola.contarClientes().ToString();
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;
        }

      

        /* private BindingSource CargarBinding()
         {
             for(int i =0; i< cola)
             {

             }
         }*/

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;
        }

        private void gridInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridInfo.Rows[e.RowIndex];
            LimpiarCampos();
            txtCodigoRuta.Text = row.Cells[1].Value.ToString();
            txtNumBus.Text = row.Cells[5].Value.ToString();
            txtIdCliente.Text = row.Cells[6].Value.ToString();
            texNombreCliente.Text = row.Cells[2].Value.ToString();
            cmbEstrato.SelectedItem = row.Cells[3].Value.ToString(); 
            cmbDestino.SelectedItem= row.Cells[7].Value.ToString();
            dtFechaRuta.Value = Convert.ToDateTime(row.Cells[4].Value);
            btnGuardar.Visible = btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            pnlDatosCliente.Visible = true;
            pnlGrilla.Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int id_Cliente = int.Parse(txtIdCliente.Text);
            Cliente nuevos_datos = cargarCliente();
            cola.ModificarPasajeroBusqueda(id_Cliente, nuevos_datos);
            bindingSource1 = cargarBindingSource();
            gridInfo.DataSource = bindingSource1;
            gridInfo.Refresh();
        }
    }
}
