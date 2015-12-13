
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoPOO.Clases
{
    [Serializable]
    public abstract class Persona {

        public string Nombre { get; set; }
        public string IDPersonal { get; set; }
        public string Email{get; set;}
        public string Domicilio{get; set;}
        public string TelefonoResidencial {get; set;}
        public string TelefonoCelular {get; set;}

        public Persona()
        {
        }

        public Persona(string nombre, string idPersonal, string email, string domicilio, 
            string casa, string cell)
        {
            this.Nombre = nombre;
            this.IDPersonal = idPersonal;
            this.Email = email;
            this.Domicilio = domicilio;
            this.TelefonoResidencial = casa;
            this.TelefonoResidencial = cell;
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}