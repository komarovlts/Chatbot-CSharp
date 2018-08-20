using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chatbot.vistas;
using Chatbot.controladores;

namespace Chatbot.controladores
{
    class ControladorDialogo
    {
        private VistaDialogo vistaDialogo;
        private ControladorChatbot controladorChatbot;

        public ControladorDialogo()
        {
            this.vistaDialogo = new VistaDialogo();
        }

        public void start()
        {
            vistaDialogo.start();

        }
    }
}
