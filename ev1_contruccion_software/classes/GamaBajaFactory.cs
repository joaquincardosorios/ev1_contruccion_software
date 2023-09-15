using ev1_contruccion_software.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ev1_contruccion_software.classes
{
    internal class GamaBajaFactory : IAbstractFactoryProductosElectronicos
    {
        private static GamaBajaFactory _instance;
        private GamaBajaFactory() { }
        public static GamaBajaFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new GamaBajaFactory();
            }
            return _instance;
        }
        public IAbstractCelulares CrearCelular()
        {
            return new TelefonoGamaBaja();
        }

        public IAbstractNotebooks CrearNotebook()
        {
            return new NotebookGamaBaja();
        }

    }
}
