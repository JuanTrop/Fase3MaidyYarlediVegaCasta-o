using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fase3MaidyYarlediCastaño.PILA;

namespace Fase3MaidyYarlediCastaño
{
    public partial class Pilas : Form
    {
        private PilaGas pila;
        BindingSource bindingSource1;
        public Pilas()
        {
            InitializeComponent();
            CargarEstratoFormulario();
            CargarCategoriaFormulario();
            pila = new PilaGas();
            bindingSource1 = new BindingSource();
            

        }      

        
        private void CargarCategoriaFormulario()
        {
            cmbCategoria.Items.Add("Seleccione");
            cmbCategoria.Items.Add("Residencial");
            cmbCategoria.Items.Add("Comercial");
            cmbCategoria.Items.Add("Urbano");
            cmbCategoria.SelectedIndex = 0;

        }

        
        private void CargarEstratoFormulario()
        {

            cmbEstrato.Items.Add("Seleccione");
            cmbEstrato.Items.Add("1");
            cmbEstrato.Items.Add("2");
            cmbEstrato.Items.Add("3");
            cmbEstrato.Items.Add("4");
            cmbEstrato.Items.Add("5");
            cmbEstrato.Items.Add("6");
            cmbEstrato.SelectedIndex = 0;
        }


        private BindingSource cargarBindingSource()
        {
           
            Stack<FacturaGas> copy = new Stack<FacturaGas>();
            BindingSource bindingSource_cargado = new BindingSource();


            if (pila.StackFacturas.Count != 0)
            {
                for (int i = 0; i <= pila.StackFacturas.Count; i++)
                {
                    FacturaGas elemento = pila.StackFacturas.Pop();
                    bindingSource_cargado.Add(elemento);
                    copy.Push(elemento);
                }

                for (int i = 0; i <= copy.Count; i++)
                {
                    FacturaGas elemento = copy.Pop();
                    pila.StackFacturas.Push(elemento);
                }
            } 
            /*else
            {
                bindingSource_cargado.Add(new PilaGas());
            }*/


            return bindingSource_cargado;
        }

        private BindingSource cargarBindingSourceBusqueda(Stack<FacturaGas> facturaBusqueda)
        {

            Stack<FacturaGas> copy = new Stack<FacturaGas>();
            BindingSource bindingSource_cargado = new BindingSource();


            if (facturaBusqueda.Count != 0)
            {
                for (int i = 0; i <= facturaBusqueda.Count; i++)
                {
                    FacturaGas elemento = facturaBusqueda.Pop();
                    bindingSource_cargado.Add(elemento);
                    copy.Push(elemento);
                }

                for (int i = 0; i <= copy.Count; i++)
                {
                    FacturaGas elemento = copy.Pop();
                    facturaBusqueda.Push(elemento);
                }
            }
            /*else
            {
                bindingSource_cargado.Add(new PilaGas());
            }*/


            return bindingSource_cargado;
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtId.Text);
            string nombre = txtNombre.Text;
            int referencia = int.Parse(txtReferencia.Text);
            int estrato = cmbEstrato.SelectedIndex;
            float consumo = float.Parse(txtConsumo.Text);
            DateTime fecha = dateTimePicker1.Value;
            int categoria = cmbCategoria.SelectedIndex;
            string direccion = txtDireccion.Text;
            float pago = float.Parse(txtPago.Text);
            
            FacturaGas factura = new FacturaGas(id, referencia, fecha, consumo, direccion, nombre, estrato, categoria, pago);
            this.pila.insertarFactura(factura);
            //bindingSource1.Add(pila.StackFacturas.Peek());
            bindingSource1 = cargarBindingSource();
            gridInfo.DataSource = new DataGridView();
            gridInfo.DataSource = bindingSource1;
            gridInfo.Refresh();

            labelSaldo.Text = pila.Saldo.ToString();
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;


        }

        

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pila.eliminarFacturaBusqueda(Convert.ToInt32(txtId.Text));
            bindingSource1 = cargarBindingSource();
            /*gridInfo.DataSource = bindingSource1;
            gridInfo.Refresh();
            gridInfo = new DataGridView();*/

            if (bindingSource1.Count!=0)
            {
                gridInfo.DataSource = bindingSource1;
                gridInfo.Refresh();
                labelSaldo.Text = pila.Saldo.ToString();
            }
            else
            {
                /* bindingSource1 = new BindingSource();
                 gridInfo.DataSource = bindingSource1;
                 gridInfo.Refresh();*/
                FacturaGas elemento = new FacturaGas();
                bindingSource1.Add(elemento);
                gridInfo.DataSource = bindingSource1;
                
                gridInfo.Refresh();
                this.gridInfo.CurrentCell = null;
                this.gridInfo.Rows[0].Visible = false;
                pnlDatosCliente.Visible = false;
                labelSaldo.Text = pila.Saldo.ToString();
            }
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;


        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtReferencia.Text = string.Empty;
            dateTimePicker1.Value = DateTime.Now;
            //CargarEstratoFormulario();
            cmbEstrato.SelectedIndex = 0;
            txtConsumo.Text = string.Empty;
            //CargarCategoriaFormulario();
            cmbCategoria.SelectedIndex = 0;
            btnGuardar.Visible = btnCancelar.Visible = true;
            btnEliminar.Visible = false;
            pnlDatosCliente.Visible = true;
            pnlGrilla.Visible = false;
            txtPago.Text = string.Empty;
            
        }

        private void gridInfo_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridInfo.Rows[e.RowIndex];
            txtId.Text = row.Cells[1].Value.ToString();
            txtNombre.Text = row.Cells[6].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells[3].Value);
            txtReferencia.Text = row.Cells[4].Value.ToString();
            txtDireccion.Text = row.Cells[5].Value.ToString();

            cmbEstrato.SelectedItem = row.Cells[8].Value.ToString();
            txtConsumo.Text = row.Cells[4].Value.ToString();
            txtPago.Text = row.Cells[9].Value.ToString();
            cmbCategoria.SelectedItem = row.Cells[8].Value.ToString();
            btnGuardar.Visible = btnCancelar.Visible = true;
            btnEliminar.Visible = true;
            pnlDatosCliente.Visible = true;
            pnlGrilla.Visible = false;
        }

       

       

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatosCliente.Visible = false;
            pnlGrilla.Visible = true;
        }
    }


   
}
