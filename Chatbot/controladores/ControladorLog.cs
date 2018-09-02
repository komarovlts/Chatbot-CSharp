using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chatbot.modelos;

namespace Chatbot.controladores
{
    public class ControladorLog
    {
        public Log log { get; set; }

        public ControladorLog()
        {
            log = new Log();
        }

        public void addLog(String mensaje)
        {
            this.log.addLog(mensaje);
        }

        public String adquirirIdentificador()
        {
            return this.log.getUltimo();
        }

        public void cargarLog(String pathFile)
        {
            List<String> loadLog = new List<String>();
            this.log = new Log();
            loadLog = this.log.loadLog(pathFile);
            loadLog.ForEach(delegate (String text)
            {
                log.addLog(text);
            });
        }
    }
}
