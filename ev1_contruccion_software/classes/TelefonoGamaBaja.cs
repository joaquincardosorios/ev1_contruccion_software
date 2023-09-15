using ev1_contruccion_software.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev1_contruccion_software.classes
{
    internal class TelefonoGamaBaja : IAbstractCelulares
    {
        public string apagado()
        {
            return "El equipo se esta apagando";
        }

        public string encendido()
        {
            return "El equipo se esta encendiendo, tiempo aproximado: 1 min";
        }

        public string iniciarApp()
        {
            return "Se está ejecutando Facebook Lite";
        }

        public string tomarFoto()
        {
            return "Se tomo una fotografia con una de 10MPx";
        }
    }
}
