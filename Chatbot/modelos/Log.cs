using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.modelos
{
    /// <summary>
    /// Esta clase define el log que contendrá todos los datos de la conversación y 
    /// todos los parametros que afectan a este.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// Gets or sets de log.
        /// </summary>
        /// <value>
        /// El parámetro log es una lista de Strings donde se irán almacenando
        /// las interacciones entre el usuario y el chatbot.
        /// </value>
        public List<String> log { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        public Log()
        {
            this.log = new List<String>();
        }

        /// <summary>
        /// Añade un mensaje a la lista log.
        /// </summary>
        /// <param name="mensaje">Mensaje dado por el usuario o por el chatbot.</param>
        public void addLog(String mensaje)
        {
            this.log.Add(mensaje);
        }

        /// <summary>
        /// Método que adquiere el último String de el Log en cuestión.
        /// </summary>
        /// <returns>String final del Log implicado.</returns>
        public String getUltimo()
        {
            String ultimoElemento;
            ultimoElemento = this.log.LastOrDefault<String>();
            return ultimoElemento;
        }

        /*
        /// <summary>
        /// Este método fue implimentado, pero durante el desarrollo se determinó que no era
        /// del todo necesario, no obstante, se deja comentado por si en algún momento se decide
        /// volver a utilizarle.
        /// Método que busca todas las repeticiones de un identificador en específico,
        /// esto para ayudar a la autoevaluación del Chatbot.
        /// </summary>
        /// <returns>Número entero que identifica la cantidad de veces que se ha 
        /// encontrado un error durante la conversación Usuario-Chatbot.</returns>
        public int searchRepeticiones()
        {
            int repeticiones = 0;
            for (int i = 0; i < log.Count; i++)
            {
                if (log[i] == "|Error|")
                {
                    repeticiones++;
                }
            }
            return repeticiones;
        }*/

        /// <summary>
        /// Método que exporta el log a un archivo de texto .txt.
        /// </summary>
        /// <param name="pathFile">Dirección en la que se desea guardar el log.</param>
        public void saveLog(String pathFile)
        {
            try
            {
                StreamWriter sw = new StreamWriter(pathFile);
                this.log.ForEach(delegate (String text)
                {
                    sw.WriteLine(text);
                });
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

        }

        /// <summary>
        /// Método que importa desde un archivo de texto al Log actual, reemplazándole.
        /// </summary>
        /// <param name="pathFile">Dirección de la que se desea cargar el log.</param>
        /// <returns>Devuelve la lista de interacciones usuario/chatbot llamada log.</returns>
        public List<String> loadLog(String pathFile)
        {
            List<String> loadLog = new List<String>();
            string linea = "";
            try
            {
                StreamReader objReader = new StreamReader(pathFile);

                while (linea != null)
                {
                    linea = objReader.ReadLine();
                    if (linea != null)
                        log.Add(linea);
                }
                objReader.Close();
                return loadLog;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
            return loadLog;
        }
    }
}
