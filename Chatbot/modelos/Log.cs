using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.modelos
{
    public class Log
    {
        public List<String> log { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Log"/> class.
        /// </summary>
        public Log()
        {
            this.log = new List<String>();
        }

        /// <summary>
        /// Adds the log.
        /// </summary>
        /// <param name="mensaje">The mensaje.</param>
        public void addLog(String mensaje)
        {
            this.log.Add(mensaje);
        }

        /// <summary>
        /// Gets the ultimo.
        /// </summary>
        /// <returns></returns>
        public String getUltimo()
        {
            String ultimoElemento;
            ultimoElemento = this.log.LastOrDefault<String>();
            return ultimoElemento;
        }

        /// <summary>
        /// Searches the repeticiones.
        /// </summary>
        /// <returns></returns>
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
        }

        /// <summary>
        /// Saves the log.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
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
        /// Loads the log.
        /// </summary>
        /// <param name="pathFile">The path file.</param>
        /// <returns></returns>
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
