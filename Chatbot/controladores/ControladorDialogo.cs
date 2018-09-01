using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chatbot.vistas;
using Chatbot.controladores;
using Chatbot.modelos;

namespace Chatbot.controladores
{
    public class ControladorDialogo
    {
        private VistaDialogo vistaDialogo;
        private ControladorChatbot controladorChatbot;
        private Log log;

        public ControladorDialogo()
        {
            this.vistaDialogo = new VistaDialogo();
        }

        public void iniciarDialogo(int personalidadChatbot)
        {
            controladorChatbot = new ControladorChatbot();
            
            controladorChatbot.start();
            controladorChatbot.beginDialog(personalidadChatbot, log);
            
        }

        public void start()
        {
            vistaDialogo.start();
        }
    }
}
