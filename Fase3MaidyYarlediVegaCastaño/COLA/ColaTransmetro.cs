using Fase3MaidyYarlediCastaño.COLA;
using System;
using System.Collections.Generic;

namespace Fase3MaidyYarlediCastaño.COLA
{

public class ColaTransmetro {
    private Queue<Cliente> colaTransmetro;

        public Queue<Cliente> ColaTransmet { get => colaTransmetro; set => colaTransmetro = value; }

        public ColaTransmetro (){
        this.colaTransmetro = new Queue<Cliente>();
    }

    public void ingresarPasajero(Cliente cliente){
        this.colaTransmetro.Enqueue(cliente);
    }

    public int contarClientes(){
        return colaTransmetro.Count;
    }

    public void eliminarPasajero(){
        colaTransmetro.Dequeue();
    }

        public void EliminarPasajeroBusqueda(int id_ruta)
        {
            if (contarClientes() != 0)
            {
                Queue<Cliente> copy = new Queue<Cliente>();
                Cliente captura = new Cliente();

                for (int i = 0; i <= colaTransmetro.Count; i++)
                {
                    Cliente elemento = colaTransmetro.Dequeue();
                    if (elemento.Id_ruta == id_ruta)
                    {
                        continue;
                    }
                    else
                    {
                        copy.Enqueue(elemento);
                    }
                }

                colaTransmetro = copy;

            }

        }

    }

}