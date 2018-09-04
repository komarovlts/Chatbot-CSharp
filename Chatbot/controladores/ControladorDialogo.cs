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

        /// <summary>
        /// Initializes a new instance of the <see cref="ControladorDialogo"/> class.
        /// </summary>
        public ControladorDialogo()
        {
            this.vistaDialogo = new VistaDialogo();
            controladorLog = new ControladorLog();
            controladorChatbot = new ControladorChatbot();
        }

        /// <summary>
        /// Backs this instance.
        /// </summary>
        public void back()
        {
            vistaDialogo.show(true);
        }

        /// <summary>
        /// Iniciars the dialogo.
        /// </summary>
        /// <param name="personalidadChatbot">The personalidad chatbot.</param>
        public void iniciarDialogo(int personalidadChatbot)
        {
            vistaDialogo.show(false);
            guardarMensaje(controladorChatbot.iniciarConversacion(personalidadChatbot,this));
            guardarMensaje("|Nombre|");
        }

        /// <summary>
        /// Finalizars the dialogo.
        /// </summary>
        public void FinalizarDialogo()
        {
            guardarMensaje(controladorChatbot.finalizarConversacion());
            guardarMensaje("|Fin de la Conversación|");

        }

        /// <summary>
        /// Interactuars this instance.
        /// </summary>
        public void interactuar()
        {
            List<String> interacciones = controladorChatbot.adquirirRespuesta();
            guardarMensaje(interacciones);
            String identificador = adquirirIdentificador();
            if (Equals(identificador, "|Listo para Finalizar|"))
            {
                controladorChatbot.cambiarEstadoBotonEnviar(false);
            }
        }

        /// <summary>
        /// Guardars the mensaje.
        /// </summary>
        /// <param name="mensaje">The mensaje.</param>
        public void guardarMensaje(String mensaje)
        {
            controladorLog.addLog(mensaje);
        }

        /// <summary>
        /// Guardars the mensaje.
        /// </summary>
        /// <param name="mensajes">The mensajes.</param>
        public void guardarMensaje(List<String> mensajes)
        {
            controladorLog.addLog(mensajes[0]);
            controladorLog.addLog(mensajes[1]);
            controladorLog.addLog(mensajes[2]);
        }

        /// <summary>
        /// Adquirirs the identificador.
        /// </summary>
        /// <returns></returns>
        public String adquirirIdentificador()
        {
            String identificador;
            identificador = controladorLog.adquirirIdentificador();
            return identificador;
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void start()
        {
            vistaDialogo.start(this);
        }

        /// <summary>
        /// Saves the log.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        public void saveLog(String pathFile)
        {
            controladorLog.log.saveLog(pathFile);
        }

        /// <summary>
        /// Loads the log.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        public void loadLog(String pathFile)
        {
            controladorLog.cargarLog(pathFile);
            rellenarChat();
        }

        /// <summary>
        /// Rellenars the chat.
        /// </summary>
        public void rellenarChat()
        {
            controladorChatbot.rellenarChat(controladorLog.log.log);
        }

        /// <summary>
        /// Adds the datos utiles.
        /// </summary>
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
