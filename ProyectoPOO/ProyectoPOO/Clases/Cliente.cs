using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
    [Serializable]
    class Cliente : Persona
    {
        public string IDPasaporte { get; set; }
        public Int16 NoMaletas { get; set; }

        public Cliente(string idPassa, Int16 maletas, string nombre, string idPersonal, string email
            , string domicilio, string casa, string cell): base (nombre, idPersonal, email, domicilio, casa, cell)
        {
            this.IDPasaporte = idPassa;
            this.NoMaletas = maletas;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
