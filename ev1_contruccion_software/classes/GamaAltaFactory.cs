using ev1_contruccion_software.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev1_contruccion_software.classes
{
    internal class GamaAltaFactory : IAbstractFactoryProductosElectronicos
    {
        private static GamaAltaFactory _instance;
        private GamaAltaFactory() { }
        public static GamaAltaFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GamaAltaFactory();
            }
            return _instance;
        }
        public IAbstractCelulares CrearCelular()
        {
            return new TelefonoGamaAlta();
        }

        public IAbstractNotebooks CrearNotebook()
        {
            return new NotebookGamaAlta();
        }

    }
}
