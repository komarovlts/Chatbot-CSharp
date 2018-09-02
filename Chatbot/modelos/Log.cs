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

        public void addLog(String mensaje)
        {
            this.log.Add(mensaje);
        }

        public String getUltimo()
        {
            String ultimoElemento;
            ultimoElemento = this.log.LastOrDefault<String>();
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
