using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPOO.Clases
{
    [Serializable]
    class TipoDeVuelo
    {
        public EClaseDeVuelo TipoClase { get; set; }
		
		public TipoDeVuelo(EClaseDeVuelo tipoClase)
		{
			this.TipoClase = tipoClase;
		}

        public float Multiplicador(EClaseDeVuelo tipo) {
            float valor = 1.0F;

            if (tipo.Equals(EClaseDeVuelo.PRIMERA))
                valor = 1.8F;
            else if (tipo.Equals(EClaseDeVuelo.TURISTA))
                valor = 1.4F;
            else if (tipo.Equals(EClaseDeVuelo.ECONOMICA))
                valor = 1.1F;
            return valor;
		}
    }
}
