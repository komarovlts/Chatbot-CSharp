using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Chatbot.modelos;
using Chatbot.vistas;


namespace Chatbot.controladores
{
    public class ControladorChatbot
    {
        private VistaChatbot vistaChatbot;
        private Usuario nuevoUsuario;
        private int personalidad { get; set; }
        private List<int> evaluaciones;

        public ControladorChatbot()
        {
            vistaChatbot = new VistaChatbot();
            this.personalidad = 1;
            this.evaluaciones = new List<int>();
        }

        public void start()
        {
            vistaChatbot.start();
        }

        public void beginDialog(int seed, Log log)
        {
            int Hora = getHora();
            String saludo;
            if (seed == 1)
            {
                if (Hora >= 6 && Hora < 12)
                {
                    saludo = timeStamp("Chatbot: Buenos Dias, ¿Cuál es tu nombre?");
                    System.out.println("Chatbot: Buenos Dias, Cual es tu nombre?");
                    log.addLog(log.getLog(), saludo);
                }
                else if (Hora >= 12 && Hora < 20)
                {
                    saludo = timeStamp("Chatbot: Buenas Tardes, ¿Cuál es tu nombre?");
                    System.out.println("Chatbot: Buenas Tardes, Cual es tu nombre?");
                    log.addLog(log.getLog(), saludo);
                }
                else if (Hora > 20)
                {
                    saludo = timeStamp("Chatbot: Buenas Noches, ¿Cuál es tu nombre?");
                    System.out.println("Chatbot: Buenas Noches, Cual es tu nombre?");
                    log.addLog(log.getLog(), saludo);
                }
                else
                {
                    saludo = timeStamp("Chatbot: Buenas, ¿Cuál es tu nombre?");
                    System.out.println("Chatbot: Buenas, Cual es tu nombre?");
                    log.addLog(log.getLog(), saludo);
                }
            }
            else
            {
                saludo = timeStamp("Chatbot: Buena!, Cómo te llamas?");
                System.out.println("Chatbot: Buena!, Como te llamas?");
                log.addLog(log.getLog(), saludo);
            }
            log.addLog(log.getLog(), "|Nombre|");
        }

        public int getHora()
        {
            DateTime momentoActual = DateTime.Now;
            int hora = momentoActual.Hour;
            return hora;
        }

        public String tiempoActual()
        {
            DateTime datosLocales = DateTime.Today;
            String tiempoActual;
            tiempoActual = (datosLocales.ToString());
            return tiempoActual;
        }

        public String timeStamp(String mensaje)
        {
            DateTime localDate = DateTime.Now;
            String stringFinal, timeStamp;
            timeStamp = tiempoActual();
            stringFinal = timeStamp + mensaje;
            return stringFinal;
        }

        /*public void addDatosFinales(Log log, Usuario usuario)
        {
            log.addLog(log.getLog(), "--------Datos Utiles--------");
            log.addLog(log.getLog(), "----Usuario----");
            log.addLog(log.getLog(), "Nombre: " + usuario.getNombreUsuario());
            log.addLog(log.getLog(), "----Chatbot----");
            log.addLog(log.getLog(), "Personalidad: " + personalidad);
            log.addLog(log.getLog(), "----Evaluaciones----");
            log.addLog(log.getLog(), (String)evaluaciones.get(0));
            log.addLog(log.getLog(), (String)evaluaciones.get(1));
            log.addLog(log.getLog(), "--------Fin Datos Utiles--------");
        }*/
    }
}
