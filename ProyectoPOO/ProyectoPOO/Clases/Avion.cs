
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoPOO.Clases
{
    [Serializable]
    public class Avion {

        public List<Boleto> clientePrimera;
        public List<Boleto> clienteTurista;
        public List<Boleto> clienteEconomica;

        public string IDAvion { get; set; }
        public Int32 NoPrimeraClase { get; set; }
        public Int32 NoTuristaClase { get; set; }
        public Int32 NoEconomicaClase { get; set; }
        private int valor = 2007;

        public Avion(string id, Int32 primera, Int32 turista, Int32 economica)
        {
            this.IDAvion = id;
            this.NoPrimeraClase = primera;
            this.NoTuristaClase = turista;
            this.NoEconomicaClase = economica;

            clientePrimera = new List<Boleto>();
            clienteTurista = new List<Boleto>();
            clienteEconomica = new List<Boleto>();
            
        }

        public void reservarAsiento(Boleto c)
        {
            if (c.tipoDeVuelo.TipoClase.Equals(EClaseDeVuelo.PRIMERA))
                if (clientePrimera.Capacity + 1 <= this.NoPrimeraClase)
                    clientePrimera.Add(c);
                else
                    throw new Exception("Ya no existen cupos disponibles de Primera Clase");
            else if (c.tipoDeVuelo.TipoClase.Equals(EClaseDeVuelo.ECONOMICA))
                if (clienteEconomica.Capacity + 1 <= this.NoEconomicaClase)
                    clienteEconomica.Add(c);
                else
                    throw new Exception("Ya no existen cupos disponibles de Clase Economica");
            else if (c.tipoDeVuelo.TipoClase.Equals(EClaseDeVuelo.TURISTA))
                if (clienteTurista.Capacity + 1 <= this.NoTuristaClase)
                    clienteTurista.Add(c);
                else
                    throw new Exception("Ya no existen cupos disponibles de Clase Turistica");
            else
                throw new Exception("No se ha selecionado el tipo de Clase");

            System.Windows.MessageBox.Show("Se han asignado los asientos");
                
        }

        public void liberarAsiento(Boleto c)
        {
            if (c.tipoDeVuelo.TipoClase.Equals(EClaseDeVuelo.PRIMERA))
                if (clientePrimera.Capacity>0)
                    clientePrimera.Remove(c);
            else if (c.tipoDeVuelo.TipoClase.Equals(EClaseDeVuelo.ECONOMICA))
                if (clienteEconomica.Capacity>0)
                    clienteEconomica.Remove(c);
            else if (c.tipoDeVuelo.TipoClase.Equals(EClaseDeVuelo.TURISTA))
                if (clienteTurista.Capacity>0)
                    clienteTurista.Remove(c);
            System.Windows.MessageBox.Show("Se han liberado los asientos");
        }
        public int asientosPrimeraDisponibles()
        {
            valor =this.NoPrimeraClase - clientePrimera.Capacity;
            return valor;
        }
        public int asientosTuristaDisponibles()
        {
            valor = this.NoTuristaClase - clienteTurista.Capacity;
            return valor;
        }
        public int asientosEconomicaDisponibles()
        {
            valor = this.NoEconomicaClase - clienteEconomica.Capacity;
            return valor;
        }


        public override string ToString()
        {
            return this.IDAvion;
        }
    }
}