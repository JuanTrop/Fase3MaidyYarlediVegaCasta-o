using System;

namespace Fase3MaidyYarlediCastaño.COLA
{

public class Cliente {
    private int id_ruta;
    private int num_bus;
    private int id_Cliente;
    private string nombre_cliente;
    private string nombre_ruta;
    private DateTime fecha_Ruta;
    private string destino_Ruta;


    public Cliente()
        {

        }

    public Cliente(int id_ruta, int num_bus, int id_Cliente, string nombre_cliente, string nombre_ruta, string destino_Ruta, DateTime fecha_Ruta)
    {
        this.Id_ruta = id_ruta;
        this.Num_bus = num_bus;
        this.Id_Cliente = id_Cliente;
        this.Nombre_cliente = nombre_cliente;
        this.Nombre_ruta = nombre_ruta;
        this.Destino_Ruta = destino_Ruta;
        this.Fecha_Ruta = fecha_Ruta;
    }

        public int Id_ruta { get => id_ruta; set => id_ruta = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Nombre_ruta { get => nombre_ruta; set => nombre_ruta = value; }
        public DateTime Fecha_Ruta { get => fecha_Ruta; set => fecha_Ruta = value; }
        public int Num_bus { get => num_bus; set => num_bus = value; }
        public int Id_Cliente { get => Id_Cliente1; set => Id_Cliente1 = value; }
        public string Destino_Ruta { get => destino_Ruta; set => destino_Ruta = value; }
        public int Id_Cliente1 { get => id_Cliente; set => id_Cliente = value; }
    }
}