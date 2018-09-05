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
        /// Aplicación Chatbot.
        /// Primer intento de MVC ó más bien MVC++ con 
        /// controlador principal "ControladorDialogo"
        /// con fines de aprender algo nuevo y útil,
        /// dejando en claro que no manejo del todo 
        /// este patrón de diseño, pero se realizó el intento y 
        /// aprendí de ello.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ControladorDialogo controladorDialogo = new ControladorDialogo();
            controladorDialogo.start();
        }
    }
}
