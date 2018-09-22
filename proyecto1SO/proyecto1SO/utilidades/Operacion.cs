using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum Comando
{
    Send,
    Receive,
    Create,
    None
}

namespace proyecto1SO.utilidades
{   
    class Operacion
    {
        public Comando comando;
        public string emisor;
        public string receptor;
        public Mensaje mensaje;
        public int prioridad;
        public Operacion()
        {
            comando = Comando.None;
            emisor = "";
            receptor = "";
            mensaje = null;
            prioridad = 0;
        }

        public Operacion(Comando pComando,  string pEmisor, string pReceptor, Mensaje pMensaje)
        {
            this.comando = pComando;
            this.emisor = pEmisor;
            this.receptor = pReceptor;
            this.mensaje = pMensaje;
        }
        public Operacion(Comando pComando, string pEmisor, string pReceptor, Mensaje pMensaje, int pPrioridad)
        {
            this.comando = pComando;
            this.emisor = pEmisor;
            this.receptor = pReceptor;
            this.mensaje = pMensaje;
            this.prioridad = pPrioridad;
        }
    }
}
