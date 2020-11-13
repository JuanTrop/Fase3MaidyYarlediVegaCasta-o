using System;

namespace Fase3MaidyYarlediCastaño.LISTA{

public class Estudiante {
    private int id;

    private string nombre;

    private int edad;

    private int estrato;

    private string programa;

    private string sede_universidad;
    private string nombre_universidad;

    private DateTime fecha_control;

    public Estudiante()
        {

        }

    public Estudiante(int id,String nombre, int edad, int estrato, String programa, String sede_universidad, String nombre_universidad, DateTime fecha_control){

        this.id = id;
        this.nombre = nombre;
        this.edad = edad;
        this.estrato = estrato;
        this.programa = programa;
        this.sede_universidad = sede_universidad;
        this.nombre_universidad = nombre_universidad;
        this.fecha_control = fecha_control;

    }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Estrato { get => estrato; set => estrato = value; }
        public string Programa { get => programa; set => programa = value; }
        public string Sede_universidad { get => sede_universidad; set => sede_universidad = value; }
        public string Nombre_universidad { get => nombre_universidad; set => nombre_universidad = value; }
        public DateTime Fecha_control { get => fecha_control; set => fecha_control = value; }
        public int Id { get => id; set => id = value; }
    }
}