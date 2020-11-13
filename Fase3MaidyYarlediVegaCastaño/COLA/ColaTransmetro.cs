using Fase3MaidyYarlediCastaño.COLA;
using System;
using System.Collections.Generic;

namespace Fase3MaidyYarlediCastaño.COLA
{

public class ColaTransmetro {
    private Queue<Cliente> colaTransmetro; //Estructura de datos Cola Queue<T>

        public Queue<Cliente> ColaTransmet { get => colaTransmetro; set => colaTransmetro = value; }

        public ColaTransmetro (){
        this.colaTransmetro = new Queue<Cliente>();
    }

        //Encolar
    public void ingresarPasajero(Cliente cliente){
        this.colaTransmetro.Enqueue(cliente);
    }
        //Contar elementos 
    public int contarClientes(){
        return colaTransmetro.Count;
    }
        //Desencolar por Dequeue()
    public void eliminarPasajero(){
        colaTransmetro.Dequeue();
    }
        //Desencolar con busqueda
        public void EliminarPasajeroBusqueda(int id_Cliente)
        {
            if (contarClientes() != 0)
            {
                Queue<Cliente> copy = new Queue<Cliente>();// Cola auxiliar
                Cliente captura = new Cliente(); //Elemento auxiliar

                for (int i = 0; i <= colaTransmetro.Count; i++)
                {
                    Cliente elemento = colaTransmetro.Dequeue();
                    if (elemento.Id_Cliente == id_Cliente)
                    {
                        continue;
                    }
                    else
                    {
                        copy.Enqueue(elemento);//Rescatar no-eliminados
                    }
                }

                colaTransmetro = copy; //Asignamos la cola auxiliar a la cola principal/original

            }
        }
            public void ModificarPasajeroBusqueda(int id_Cliente, Cliente nuevos_datos)
            {
                if (contarClientes() != 0)
                {
                    Queue<Cliente> copy = new Queue<Cliente>();// Cola auxiliar
                    Cliente captura = new Cliente(); //Elemento auxiliar

                    for (int i = 0; i <= colaTransmetro.Count; i++)
                    {
                        Cliente datos_viejos = colaTransmetro.Dequeue();
                        if (datos_viejos.Id_Cliente == id_Cliente)
                        {
                        datos_viejos = nuevos_datos;
                        copy.Enqueue(datos_viejos);
                    }
                        else
                        {
                            copy.Enqueue(datos_viejos);//Rescatar no-eliminados
                        }
                    }

                    colaTransmetro = copy; //Asignamos la cola auxiliar a la cola principal/original

                }

            }

    }

}