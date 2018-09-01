using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chatbot.modelos
{
    public class Log
    {
        public List<String> log { get; set; }

        public Log()
        {
            this.log = new List<String>();
        }

        public List<String> addLog(List<String> log, String mensaje)
        {
            this.log = log;
            log.Add(mensaje);
            return log;
        }

        public String getUltimo(List<String> log)
        {
            String ultimoElemento;
            ultimoElemento = log.LastOrDefault<String>();
            return ultimoElemento;
        }

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

    }
}
