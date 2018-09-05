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
        private vistas.VistaRate vistaRate;
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
        /// Inicia la vista chatbot.
        /// Interacción entre controlador/vista.
        /// </summary>
        public void start()
        {
            vistaChatbot.start(this);
        }

        /// <summary>
        /// Inicia la vista de rate.
        /// Interacción entre controlador/vista.
        /// </summary>
        public void startRate()
        {
            vistaRate.start(this);
        }

        /// <summary>
        /// Adquiere la evaluación del chatbot.
        /// Interacción entre controlador/controladorPrincipal.
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
        /// Volver a la vista chatbot.
        /// Interacción entre controlador/vista.
        /// </summary>
        public void back()
        {
            vistaChatbot.show(false);
            controladorDialogo.back();
        }

        /// <summary>
        /// Inicia la conversación
        /// Interacción entre controlador/vista.
        /// </summary>
        /// <param name="personalidad">Personalidad del chatbot.</param>
        /// <param name="controladorDialogo">Controlador Dialogo.</param>
        /// <returns>Mensaje de inicio de ocnversación con sus parámetros de tiempo</returns>
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
        /// Finaliza la conversación agregando un poco de delay antes
        /// de cambiar a la ventana de rate, para así mostrar y que sea
        /// legible el mensaje de despedida antes de desaparecer la vista
        /// del chatbot.
        /// Interacción entre controlador/vista.
        /// </summary>
        /// <returns></returns>
        public String finalizarConversacion()
        {
            mensaje = timeStamp(chatbot.endDialog());
            vistaChatbot.escribirEnCajaTextoGrande(mensaje);
            //Añadir delay.
            DateTime Tthen = DateTime.Now;
            do
            {
                Application.DoEvents();
            } while (Tthen.AddSeconds(2) > DateTime.Now);
            //Final de delay.
            vistaRate = new vistas.VistaRate();
            startRate();
            vistaChatbot.vaciarChat();
            vistaChatbot.show(false);
            return mensaje;
        }

        /// <summary>
        /// Finalizador del dialogo.
        /// Interacción entre controlador/controladorPrincipal.
        /// </summary>
        public void finalizador()
        {
            controladorDialogo.FinalizarDialogo();
        }

        /// <summary>
        /// Interacción con el usuario.
        /// Interacción entre controlador/controladorPrincipal.
        /// </summary>
        public void interaccionConUsuario()
        {
            controladorDialogo.interactuar();
        }

        /// <summary>
        /// Adquiere la respuesta del chatbot según la respuesta del usuario
        /// y el identificador.
        /// Interacción entre controlador/modelo.
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
        /// Cambia el estado del botón enviar.
        /// </summary>
        /// <param name="activar">Booleano que activa o desactiva el botón enviar</param>
        public void cambiarEstadoBotonEnviar(bool activar)
        {
            vistaChatbot.estadoBotonEnviar(activar);
        }

        /// <summary>
        /// Conversación entre usuario y chatbot según la respuesta
        /// del usuario y del último identificador.
        /// Interacción entre controlador/modelo.
        /// </summary>
        /// <param name="respuestaUsuario">Respuesta del usuario.</param>
        /// <param name="identificador">Último identificador del log.</param>
        /// <returns></returns>
        public List<String> conversacion(String respuestaUsuario,String identificador)
        {
            List<String> mensajes;
            mensajes = chatbot.dialog(respuestaUsuario, identificador);
            return mensajes;
        }

        /// <summary>
        /// Adquiere los parámetros de tiempo (hora y fecha) actual del ordenador.
        /// </summary>
        /// <returns>Devuelve un string con los parámetros de tiempo.</returns>
        public String tiempoActual()
        {
            DateTime datosLocales = DateTime.Now;
            String tiempoActual;
            tiempoActual = (datosLocales.ToString());
            return tiempoActual;
        }

        /// <summary>
        /// Agrega los parámetros de tiempo (hora y fecha actual)
        /// a un mensaje.
        /// </summary>
        /// <param name="mensaje">The mensaje.</param>
        /// <returns>String compuesto entre parámetros de tiempo y el mensaje.</returns>
        public String timeStamp(String mensaje)
        {
            String stringFinal, timeStamp;
            timeStamp = tiempoActual();
            stringFinal = "[" + timeStamp + "] " + mensaje;
            return stringFinal;
        }

        /// <summary>
        /// Rellena el chat con el contenido de un log.
        /// Interacción entre controlador/vista.
        /// </summary>
        /// <param name="loadLog">log cargado.</param>
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
        /// Guarda el log.
        /// Interacción entre controlador/vista.
        /// </summary>
        /// <param name="pathFile">Dirección del archivo.</param>
        public void saveLog(String pathFile)
        {
            controladorDialogo.saveLog(pathFile);
            vistaChatbot.ventanaExitoSaveLog();
        }

        /// <summary>
        /// Carga el log.
        /// Interacción entre controlador/vista.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        public void loadLog(String pathFile)
        {
            controladorDialogo.loadLog(pathFile);
            vistaChatbot.ventanaExitoLoadLog();
        }
    }
}
