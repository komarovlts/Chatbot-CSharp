using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chatbot.modelos;

namespace Chatbot.controladores
{
    /// <summary>
    /// Sub-controlador
    /// </summary>
    public class ControladorLog
    {
        /// <summary>
        /// Gets or sets del log.
        /// </summary>
        /// <value>
        /// log
        /// </value>
        public Log log { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ControladorLog"/> class.
        /// </summary>
        public ControladorLog()
        {
            log = new Log();
        }

        /// <summary>
        /// Añade al final de la lista log el String dado.
        /// Interacción entre controlador/modelo.
        /// </summary>
        /// <param name="mensaje">Mensaje del usuario, chatbot o un identificador.</param>
        public void addLog(String mensaje)
        {
            this.log.addLog(mensaje);
        }

        /// <summary>
        /// Adquirir el identificador del final de la lista
        /// Interacción entre controlador/modelo..
        /// </summary>
        /// <returns></returns>
        public String adquirirIdentificador()
        {
            return this.log.getUltimo();
        }

        /// <summary>
        /// Cargar log.
        /// Interacción entre controlador/modelo.
        /// </summary>
        /// <param name="pathFile">Dirección del archivo en cuestión.</param>
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
