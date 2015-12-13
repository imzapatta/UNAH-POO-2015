using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
    [Serializable]
    class Destino
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }

        public Destino (string nombre, float precio)
        {
            this.Nombre = nombre;
            this.Precio = precio;
        }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
