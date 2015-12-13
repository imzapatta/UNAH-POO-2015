using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoPOO.Clases
{
    [Serializable]
    class Vuelo
    {
        public string IDVuelo { get; set; }
        public Avion Avion { get; set; }
        public string Ruta { get; set; }
        public Destino Destino { get; set; }

        public Vuelo(string id, Avion avion, string ruta, Destino destino)
        {
            this.IDVuelo = id;
            this.Avion = avion;
            this.Ruta = ruta;
            this.Destino = destino;
        }

        public void asignarAsientos(Boleto c)
        {
            this.Avion.reservarAsiento(c);
        }
        public void liberarAsientos(Boleto c)
        {
            this.Avion.liberarAsiento(c);
        }
        public override string ToString()
        {
            return this.IDVuelo;
        }
    }
}
