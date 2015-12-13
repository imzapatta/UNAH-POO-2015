using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
    [Serializable]
    class Empleado : Persona
    {
        public string IDEmpleado { get; set; }
        public string PinTarjeta { get; set; }

        public Empleado(string id, string pin, string nombre, string idpersonal, string email, string domicilio, string casa, string cell) :
            base(nombre, idpersonal, email, domicilio, casa, cell)
        {
            this.IDEmpleado = id;
            this.PinTarjeta = pin;
        }
    }
}
