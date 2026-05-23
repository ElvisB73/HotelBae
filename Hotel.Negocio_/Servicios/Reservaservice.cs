using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Negocio_.Servicios
{
    public class Reservaservice
    {
        public bool ValidarTipoHabitacion(string tipo)
        {
            if (string.IsNullOrWhiteSpace(tipo))
            {
                return false;
            }

            if (tipo == "Sencilla" || tipo == "Doble" || tipo == "Suite")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
