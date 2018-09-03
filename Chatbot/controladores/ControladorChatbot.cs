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

        public ControladorChatbot()
        {
            vistaChatbot = new VistaChatbot();
        }

        public void start()
        {
            vistaChatbot.start(this);
        }

        public void startRate()
        {
            vistaRate.start(this);
        }

        public void adquirirEvaluaciones()
        {
            int evaluacion = vistaRate.adquirirEvaluacion();
            chatbot.evaluaciones = evaluacion;
            controladorDialogo.addDatosUtiles();
            vistaRate.Close();
            controladorDialogo.back();
        }

        public void back()
        {
            vistaChatbot.show(false);
            controladorDialogo.back();
        }

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
        public void addDelay()
        {
            int milliseconds = 2000;
            Thread.Sleep(milliseconds);
        }

        public void finalizador()
        {
            controladorDialogo.FinalizarDialogo();
        }

        public void interaccionConUsuario()
        {
            controladorDialogo.interactuar();
        }

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

        public void cambiarEstadoBotonEnviar(bool activar)
        {
            vistaChatbot.estadoBotonEnviar(activar);
        }

        public List<String> conversacion(String respuestaUsuario,String identificador)
        {
            List<String> mensajes;
            mensajes = chatbot.dialog(respuestaUsuario, identificador);
            return mensajes;
        }

        public String tiempoActual()
        {
            DateTime datosLocales = DateTime.Now;
            String tiempoActual;
            tiempoActual = (datosLocales.ToString());
            return tiempoActual;
        }

        public String timeStamp(String mensaje)
        {
            String stringFinal, timeStamp;
            timeStamp = tiempoActual();
            stringFinal = "[" + timeStamp + "] " + mensaje;
            return stringFinal;
        }

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

        public void saveLog(String pathFile)
        {
            controladorDialogo.saveLog(pathFile);
            vistaChatbot.ventanaExitoSaveLog();
        }

        public void loadLog(String pathFile)
        {
            controladorDialogo.loadLog(pathFile);
            vistaChatbot.ventanaExitoLoadLog();
        }
    }
}
