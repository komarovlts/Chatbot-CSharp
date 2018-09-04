using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Chatbot.modelos;
using Chatbot.vistas;


namespace Chatbot.controladores
{
    public class ControladorChatbot
    {
        private VistaChatbot vistaChatbot;
        private VistaRate vistaRate;
        private ControladorDialogo controladorDialogo;
        public Usuario usuario;
        public Sellerbot chatbot;
        private String mensaje;

        /// <summary>
        /// Initializes a new instance of the <see cref="ControladorChatbot"/> class.
        /// </summary>
        public ControladorChatbot()
        {
            vistaChatbot = new VistaChatbot();
        }

        /// <summary>
        /// Starts this instance.
        /// </summary>
        public void start()
        {
            vistaChatbot.start(this);
        }

        /// <summary>
        /// Starts the rate.
        /// </summary>
        public void startRate()
        {
            vistaRate.start(this);
        }

        /// <summary>
        /// Adquirirs the evaluaciones.
        /// </summary>
        public void adquirirEvaluaciones()
        {
            int evaluacion = vistaRate.adquirirEvaluacion();
            chatbot.evaluaciones = evaluacion;
            controladorDialogo.addDatosUtiles();
            vistaRate.Close();
            controladorDialogo.back();
        }

        /// <summary>
        /// Backs this instance.
        /// </summary>
        public void back()
        {
            vistaChatbot.show(false);
            controladorDialogo.back();
        }

        /// <summary>
        /// Iniciars the conversacion.
        /// </summary>
        /// <param name="personalidad">The personalidad.</param>
        /// <param name="controladorDialogo">The controlador dialogo.</param>
        /// <returns></returns>
        public String iniciarConversacion(int personalidad, ControladorDialogo controladorDialogo)
        {
            usuario = new Usuario();
            chatbot = new Sellerbot();
            this.controladorDialogo = controladorDialogo;
            chatbot.personalidad = personalidad;
            start();
            cambiarEstadoBotonEnviar(true);
            mensaje = timeStamp(chatbot.beginDialog(personalidad));
            vistaChatbot.escribirEnCajaTextoGrande(mensaje);
            return mensaje;
        }

        /// <summary>
        /// Finalizars the conversacion.
        /// </summary>
        /// <returns></returns>
        public String finalizarConversacion()
        {
            mensaje = timeStamp(chatbot.endDialog());
            vistaChatbot.escribirEnCajaTextoGrande(mensaje);
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(2) > DateTime.Now);
            vistaRate = new VistaRate();
            startRate();
            vistaChatbot.vaciarChat();
            vistaChatbot.show(false);
            return mensaje;
        }

        /// <summary>
        /// Adds the delay.
        /// </summary>
        public void addDelay()
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        /// <summary>
        /// Finalizadors this instance.
        /// </summary>
        public void finalizador()
        {
            controladorDialogo.FinalizarDialogo();
        }

        /// <summary>
        /// Interaccions the con usuario.
        /// </summary>
        public void interaccionConUsuario()
        {
            controladorDialogo.interactuar();
        }

        /// <summary>
        /// Adquirirs the respuesta.
        /// </summary>
        /// <returns></returns>
        public List<String> adquirirRespuesta()
        {
            List<String> mensajes = new List<String>();
            List<String> listaConversacion = new List<String>();
            String respuestaUsuario;
            String identificador;
            respuestaUsuario = vistaChatbot.adquirirDeCajaTexto();
            if (respuestaUsuario != "")
            {
                identificador = controladorDialogo.adquirirIdentificador();
                if (Equals(identificador, "|Nombre|")) {
                    usuario.nombreUsuario = respuestaUsuario;
                }
                vistaChatbot.escribirEnCajaTextoGrande(timeStamp("Usuario: " + respuestaUsuario));
                listaConversacion = conversacion(respuestaUsuario, identificador);
                vistaChatbot.escribirEnCajaTextoGrande(timeStamp(listaConversacion[0]));
                mensajes.Add(timeStamp(respuestaUsuario));
                mensajes.Add(timeStamp(listaConversacion[0]));
                mensajes.Add(listaConversacion[1]);
                return mensajes;
            }
            //Revisar esto.
            return mensajes;
        }

        /// <summary>
        /// Cambiars the estado boton enviar.
        /// </summary>
        /// <param name="activar">if set to <c>true</c> [activar].</param>
        public void cambiarEstadoBotonEnviar(bool activar)
        {
            vistaChatbot.estadoBotonEnviar(activar);
        }

        /// <summary>
        /// Conversacions the specified respuesta usuario.
        /// </summary>
        /// <param name="respuestaUsuario">The respuesta usuario.</param>
        /// <param name="identificador">The identificador.</param>
        /// <returns></returns>
        public List<String> conversacion(String respuestaUsuario,String identificador)
        {
            List<String> mensajes;
            mensajes = chatbot.dialog(respuestaUsuario, identificador);
            return mensajes;
        }

        /// <summary>
        /// Tiempoes the actual.
        /// </summary>
        /// <returns></returns>
        public String tiempoActual()
        {
            DateTime datosLocales = DateTime.Now;
            String tiempoActual;
            tiempoActual = (datosLocales.ToString());
            return tiempoActual;
        }

        /// <summary>
        /// Times the stamp.
        /// </summary>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns></returns>
        public String timeStamp(String mensaje)
        {
            String stringFinal, timeStamp;
            timeStamp = tiempoActual();
            stringFinal = "[" + timeStamp + "] " + mensaje;
            return stringFinal;
        }

        /// <summary>
        /// Rellenars the chat.
        /// </summary>
        /// <param name="loadLog">The load log.</param>
        public void rellenarChat(List<String> loadLog)
        {
            vistaChatbot.vaciarChat();
            loadLog.ForEach(delegate (String text)
            {
                if(!Equals(text,"|Nombre|") && !Equals(text,"|Respuesta1|") && !Equals(text,"|Respuesta2|") && !Equals(text,"|Respuesta3|") &&
                !Equals(text,"|Respuesta4|") && !Equals(text,"|Listo para Finalizar|") && !Equals(text,"|Fin de la Conversación|"))
                vistaChatbot.escribirEnCajaTextoGrande(text);
            });
        }

        /// <summary>
        /// Saves the log.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        public void saveLog(String pathFile)
        {
            controladorDialogo.saveLog(pathFile);
            vistaChatbot.ventanaExitoSaveLog();
        }

        /// <summary>
        /// Loads the log.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        public void loadLog(String pathFile)
        {
            controladorDialogo.loadLog(pathFile);
            vistaChatbot.ventanaExitoLoadLog();
        }
    }
}
