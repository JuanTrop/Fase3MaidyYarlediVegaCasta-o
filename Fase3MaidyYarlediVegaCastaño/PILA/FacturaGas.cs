using System;

namespace Fase3MaidyYarlediCastaño.PILA 
{

    public class FacturaGas
    {

        private int id_factura;
        private int num_factura;
        private DateTime fecha;
        private float consumo;
        private string cliente_direccion;
        private string cliente_nombre;
        private int cliente_estrato;
        private int cliente_categoria;
        private float pago;

        public FacturaGas()
        {

        }

        public FacturaGas(int id_factura, int num_factura, DateTime fecha, float consumo, string cliente_direccion, string cliente_nombre, int cliente_estrato, int cliente_categoria, float pago)
        {
            this.id_factura = id_factura;
            this.num_factura = num_factura;
            this.fecha = fecha;
            this.consumo = consumo;
            this.cliente_direccion = cliente_direccion;
            this.cliente_nombre = cliente_nombre;
            this.cliente_estrato = cliente_estrato;
            this.cliente_categoria = cliente_categoria;
            this.Pago = pago;
        }

        public int Id_Factura { get => id_factura; set => id_factura = value; }
        public int Num_factura { get => num_factura; set => num_factura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public float Consumo { get => consumo; set => consumo = value; }
        public string Cliente_direccion { get => cliente_direccion; set => cliente_direccion = value; }
        public string Cliente_nombre { get => cliente_nombre; set => cliente_nombre = value; }
        public int Cliente_estrato { get => cliente_estrato; set => cliente_estrato = value; }
        public int Cliente_categoria { get => cliente_categoria; set => cliente_categoria = value; }
        public float Pago { get => pago; set => pago = value; }
    }
}