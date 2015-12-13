
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoPOO.Clases
{
    [Serializable]
    public class Boleto{

        
        public float Precio { get; set; }
        public TipoDeVuelo tipoDeVuelo { get; set; }
        public string IDBoleto { get; set; }
        public  Cliente Cliente { get; set; }
        public Vuelo Asiento { get; set; }//En realidad es el vuelo, no modifiqué el nombre /.\
        public DateTime fechaViaje { get; set; }
        public DateTime fechaCompra { get; set; }


        public Boleto (string idBoleto, Cliente cliente, Vuelo Asiento, TipoDeVuelo tipoVuelo, DateTime fechaDeViaje, DateTime fechaCompra)
        {
            this.IDBoleto = idBoleto;
            this.Cliente = cliente;
            this.Asiento = Asiento;
            this.tipoDeVuelo = tipoVuelo;
            this.fechaViaje = fechaDeViaje;
            this.fechaCompra = fechaCompra;

            // el precio del boleto sale del precio que tiene el vuelo al destino (siempre parte de TGU) * la clase donde viajas(Primera...) * el aumento de la temporada de vuelo)
            this.Precio = Asiento.Destino.Precio* tipoVuelo.Multiplicador(tipoVuelo.TipoClase)*multiplicadorDeCompra(fechaCompra);

            Asiento.asignarAsientos(this);
        }

        public float multiplicadorDeCompra(DateTime compra)
        {
            float valor = 1.0F;

            if (compra.Month == 1 || compra.Month == 12 || compra.Month == 6)
                valor = 1.6F;
            else if (compra.Month == 2 || compra.Month == 11 || compra.Month == 5)
                valor = 1.4F;
            else  if (compra.Month == 3 || compra.Month == 10 || compra.Month == 7)
                valor = 1.2F;
            else  if (compra.Month == 4 || compra.Month == 9 || compra.Month == 8)
                valor = 1.1F;
            else 
                valor = 1.0F;

            return valor;
        }

        public void eliminarBoletoDelSistema()
        {
            this.Asiento.liberarAsientos(this);
        }
    }
}