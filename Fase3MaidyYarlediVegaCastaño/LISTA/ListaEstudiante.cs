using System;
using System.Collections.Generic;

namespace Fase3MaidyYarlediCastaño.LISTA
{
    
public class ListaEstudiante {
    private List<Estudiante> listaEstudiantes; //Estructura de datos Lista List<T>

        public List<Estudiante> ListaEstudiantes { get => listaEstudiantes; set => listaEstudiantes = value; }

        public ListaEstudiante(){
        this.ListaEstudiantes = new List<Estudiante>();
    }

    //Enlistar (Sea a la derecha o a la izquierda)
    public void insertarEstudiante(Estudiante estudiante){
        this.ListaEstudiantes.Add(estudiante);//Añade al ultimo elemento
    }

    //Dar de baja con busqueda
    public Boolean eliminarEstudiante(int id_estudiante)
    {
        for(int i = 0; i < contarEstudiantes(); i++)
            {
                if (listaEstudiantes[i].Id == id_estudiante)
                {
                    return this.ListaEstudiantes.Remove(listaEstudiantes[i]);
                }
            }
            return false;
        
    }
        //Modificar elemento
        public void ModificarEstudiante(int id_estudiante, Estudiante nuevos_datos)
        {
            for (int i = 0; i < contarEstudiantes(); i++)
            {
                if (listaEstudiantes[i].Id == id_estudiante)
                {
                    listaEstudiantes[i] = nuevos_datos; //Actualiza los datos del estudiante
                }
            }

        }
        //Contar elementos
        public int contarEstudiantes(){
        return this.ListaEstudiantes.Count;
    }
    
    //Busqueda
    public List<Estudiante> obtenerEstudiante(int id_estudiante)
        {
            List<Estudiante> estudiantes_encontrados = new List<Estudiante>();
            for(int i = 0; i < ListaEstudiantes.Count; i++)
            {
                if (ListaEstudiantes[i].Id == id_estudiante)
                {
                    estudiantes_encontrados.Add(ListaEstudiantes[i]);
                }
            }
            return estudiantes_encontrados;
        }
}

}