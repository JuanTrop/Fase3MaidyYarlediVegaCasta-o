using System;
using System.Collections.Generic;

namespace Fase3MaidyYarlediCastaño.LISTA
{
    
public class ListaEstudiante {
    private List<Estudiante> listaEstudiantes;

        public List<Estudiante> ListaEstudiantes { get => listaEstudiantes; set => listaEstudiantes = value; }

        public ListaEstudiante(){
        this.ListaEstudiantes = new List<Estudiante>();
    }

    public void insertarEstudiante(Estudiante estudiante){
        this.ListaEstudiantes.Add(estudiante);
    }

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

    public int contarEstudiantes(){
        return this.ListaEstudiantes.Count;
    }

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