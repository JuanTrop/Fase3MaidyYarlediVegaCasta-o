using System;
using System.Collections.Generic;

namespace Fase3MaidyYarlediCastaño.PILA
{
    
public class PilaGas{
    private double saldo;
    private Stack<FacturaGas> stackFacturas;

    public double Saldo { get => saldo; set => saldo = value; }
    public Stack<FacturaGas> StackFacturas { get => stackFacturas; set => stackFacturas = value; }

    public PilaGas(){
        this.Saldo = 0;
        this.StackFacturas = new Stack<FacturaGas>(); 
    } 
    public void insertarFactura(FacturaGas factura){
        this.Saldo += factura.Pago;
        StackFacturas.Push(factura);
    }

    public FacturaGas eliminarFactura(){
        FacturaGas salida = this.StackFacturas.Pop();
            if (contarFacturas() != 0)
            {
                this.Saldo = this.Saldo - salida.Consumo;
            }
        return salida;
    }

    public void eliminarFacturaBusqueda(int id)
        {
            Stack<FacturaGas> copy = new Stack<FacturaGas>();
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
                        copy.Push(elemento);
                    }
                }

                for (int i = 0; i < copy.Count; i++)
                {
                    this.StackFacturas.Push(copy.Pop());
                }
            }

        }
       

        public int contarFacturas(){
        return this.StackFacturas.Count;
    }

    public double getSaldo(){
        return this.Saldo;
    }


}
}