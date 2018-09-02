using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chatbot.vistas;
using Chatbot.modelos;

namespace Chatbot.controladores
{
    public class ControladorDialogo
    {
        private VistaDialogo vistaDialogo;
        private ControladorChatbot controladorChatbot;
        private ControladorLog controladorLog;

        public ControladorDialogo()
        {
            this.vistaDialogo = new VistaDialogo();
            controladorLog = new ControladorLog();
            controladorChatbot = new ControladorChatbot();
        }

        public void back()
        {
            vistaDialogo.show(true);
        }

        public void iniciarDialogo(int personalidadChatbot)
        {
            vistaDialogo.show(false);
            guardarMensaje(controladorChatbot.iniciarConversacion(personalidadChatbot,this));
            guardarMensaje("|Nombre|");
        }

        public void FinalizarDialogo()
        {
            guardarMensaje(controladorChatbot.finalizarConversacion());
            guardarMensaje("|Fin de la Conversación|");

        }

        public void interactuar()
        {
            List<String> interacciones = controladorChatbot.adquirirRespuesta();
            guardarMensaje(interacciones);
        }

        public void guardarMensaje(String mensaje)
        {
            controladorLog.addLog(mensaje);
        }

        public void guardarMensaje(List<String> mensajes)
        {
            controladorLog.addLog(mensajes[0]);
            controladorLog.addLog(mensajes[1]);
            controladorLog.addLog(mensajes[2]);
        }

        public String adquirirIdentificador()
        {
            String identificador;
            identificador = controladorLog.adquirirIdentificador();
            return identificador;
        }

        public void start()
        {
            vistaDialogo.start(this);
        }

        public void saveLog(String pathFile)
        {
            controladorLog.log.saveLog(pathFile);
        }

        public void loadLog(String pathFile)
        {
            controladorLog.cargarLog(pathFile);
            rellenarChat();
        }

        public void rellenarChat()
        {
            controladorChatbot.rellenarChat(controladorLog.log.log);
        }

        public void addDatosUtiles()
        {
            guardarMensaje("--------Datos Utiles--------");
            guardarMensaje("----Usuario----");
            guardarMensaje("Nombre: " + controladorChatbot.usuario.nombreUsuario);
            guardarMensaje("----Chatbot----");
            guardarMensaje("Personalidad: " + controladorChatbot.chatbot.personalidad);
            guardarMensaje("----Evaluaciones----");
            guardarMensaje(controladorChatbot.chatbot.evaluaciones.ToString());
            guardarMensaje("--------Fin Datos Utiles--------");

        }
    }
}
