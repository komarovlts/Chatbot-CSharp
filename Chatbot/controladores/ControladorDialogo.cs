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
        /// Muestra la vista dialogo.
        /// Interacción entre controladorPrincipal/vista.
        /// </summary>
        public void back()
        {
            vistaDialogo.show(true);
        }

        /// <summary>
        /// Inicia el dialogo
        /// Interacción entre controladorPrincipal/vista.
        /// </summary>
        /// <param name="personalidadChatbot">Personalidad del chatbot.</param>
        public void iniciarDialogo(int personalidadChatbot)
        {
            vistaDialogo.show(false);
            guardarMensaje(controladorChatbot.iniciarConversacion(personalidadChatbot,this));
            guardarMensaje("|Nombre|");
        }

        /// <summary>
        /// Finaliza el dialogo.
        /// Interacción entre controladorPrincipal/controlador.
        /// </summary>
        public void FinalizarDialogo()
        {
            guardarMensaje(controladorChatbot.finalizarConversacion());
            guardarMensaje("|Fin de la Conversación|");

        }

        /// <summary>
        /// Interracción entre usuario y chatbot (forma de representar su dialogo).
        /// Interacción entre controladorPrincipal/controlador.
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
        /// Guarda el mensaje en el log cuando es un String.
        /// Interacción entre controladorPrincipal/controlador.
        /// </summary>
        /// <param name="mensaje">Mensaje del usuario ó chatbot.</param>
        public void guardarMensaje(String mensaje)
        {
            controladorLog.addLog(mensaje);
        }

        /// <summary>
        /// Guarda el mensaje en el log cuando este es una lista de Strings.
        /// Interacción entre controladorPrincipal/controlador.
        /// </summary>
        /// <param name="mensajes">The mensajes.</param>
        public void guardarMensaje(List<String> mensajes)
        {
            controladorLog.addLog(mensajes[0]);
            controladorLog.addLog(mensajes[1]);
            controladorLog.addLog(mensajes[2]);
        }

        /// <summary>
        /// Adquiere el identificador actual (último en el log).
        /// Interacción entre controladorPrincipal/modelo.
        /// </summary>
        /// <returns></returns>
        public String adquirirIdentificador()
        {
            String identificador;
            identificador = controladorLog.adquirirIdentificador();
            return identificador;
        }

        /// <summary>
        /// Inicia la vista dialogo.
        /// Interacción entre controladorPrincipal/vista.
        /// </summary>
        public void start()
        {
            vistaDialogo.start(this);
        }

        /// <summary>
        /// Guarda el log en la ubicación dada.
        /// Interacción entre controladorPrincipal/controlador.
        /// </summary>
        /// <param name="pathFile">Dirección del archivo.</param>
        public void saveLog(String pathFile)
        {
            controladorLog.log.saveLog(pathFile);
        }

        /// <summary>
        /// Carga el log en al ubicación dada.
        /// Interacción entre controladorPrincipal/controlador.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        public void loadLog(String pathFile)
        {
            controladorLog.cargarLog(pathFile);
            rellenarChat();
        }

        /// <summary>
        /// Rellena el chat del chatbot.
        /// Interacción entre controladorPrincipal/controlador.
        /// </summary>
        public void rellenarChat()
        {
            controladorChatbot.rellenarChat(controladorLog.log.log);
        }

        /// <summary>
        /// Añade datos útiles al final del log,
        /// este registro sólo es visible en el archivo de texto
        /// al guardar un log.
        /// Interacción entre controladorPrincipal/controlador/modelo.
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
