using System;
using System.Collections.Generic;

namespace Fase3MaidyYarlediCastaño.PILA
{
    
public class PilaGas{
    private double saldo; //Se acumulan los pagos de cada factura en la pila
    private Stack<FacturaGas> stackFacturas; //Estructura de datos Stack<T>

    public double Saldo { get => saldo; set => saldo = value; }
    public Stack<FacturaGas> StackFacturas { get => stackFacturas; set => stackFacturas = value; }

    public PilaGas(){
        this.Saldo = 0;
        this.StackFacturas = new Stack<FacturaGas>(); 
    } 

    //Cuando inserta con Push() actualiza el saldo
    public void insertarFactura(FacturaGas factura){
        this.Saldo += factura.Pago;
        StackFacturas.Push(factura);
    }

    //Fundamental, elimina el primer elemento de la pila con Pop()
    public FacturaGas eliminarFactura(){
        FacturaGas salida = this.StackFacturas.Pop();
            if (contarFacturas() != 0)
            {
                this.Saldo = this.Saldo - salida.Pago;
            }
        return salida;
    }

    //eliminar buscando en la pila una factura con id semejante, usando las reglas de acceso LiFo de una pila
    //
    public void eliminarFacturaBusqueda(int id)
        {
            Stack<FacturaGas> copy = new Stack<FacturaGas>(); //pila auxiliar
            if (contarFacturas() != 0)
            {
                for (int i = 0; i <= StackFacturas.Count; i++)
                {
                    FacturaGas elemento = this.StackFacturas.Pop();
                    this.Saldo = this.Saldo - elemento.Pago;
                    if (elemento.Id_Factura == id)
                    {
                        continue;
                    }
                    else
                    {
                        copy.Push(elemento); //recupera los no-eliminados
                    }
                }

                //Se rellena la pila principal/original
                for (int i = 0; i < copy.Count; i++)
                {
                    this.StackFacturas.Push(copy.Pop());
                }
            }

        }

        public void modificarFacturaBusqueda(int id, FacturaGas nuevos_datos)
        {
            Stack<FacturaGas> copy = new Stack<FacturaGas>(); //pila auxiliar
            if (contarFacturas() != 0)
            {
                for (int i = 0; i <= StackFacturas.Count; i++)
                {
                    FacturaGas datos_viejos = this.StackFacturas.Pop();

                    if (datos_viejos.Id_Factura == id)
                    {
                        datos_viejos = nuevos_datos;
                        copy.Push(datos_viejos);
                    }
                    else
                    {
                        copy.Push(datos_viejos); 
                    }
                }

                //Se rellena la pila principal/original
                for (int i = 0; i < copy.Count; i++)
                {
                    this.StackFacturas.Push(copy.Pop());
                }
            }

        }

        //Cantidad de facturas en pila
        public int contarFacturas(){
        return this.StackFacturas.Count;
    }

    //Saldo de facturas
    public double getSaldo(){
        return this.Saldo;
    }


}
}