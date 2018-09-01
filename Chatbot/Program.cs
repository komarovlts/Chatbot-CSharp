using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chatbot.vistas;
using Chatbot.controladores;

namespace Chatbot
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ControladorDialogo controladorDialogo = new ControladorDialogo();
            controladorDialogo.start();
        }
    }
}
