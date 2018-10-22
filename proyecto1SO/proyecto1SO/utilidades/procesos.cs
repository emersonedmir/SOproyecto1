using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace proyecto1SO.utilidades
{
    public static class hilosSpooler
    {
        public static List<Thread> hilosApp;
        public static List<Thread> hilosMailBox;
    }
    public static class procesos
    {
        public static List<hilo> lstProcesos = new List<hilo>();    //contiene las referencias de la direccion de memoria de los procesos
    }
    public static class procesosDDin
    {
        public static List<Mensaje> lstProcesosDDin = new List<Mensaje>();    //contiene las referencias de la direccion de memoria de los procesos
    }
    public static class puertos
    {
        public static List<MailBox> lstMailBox = new List<MailBox>();  //buzon compartido para direccionamiento send indirecto
        public static int Get_IdxMailBox(int pPuerto)
        {
            int i;
            for (i = 0; i < puertos.lstMailBox.Count; i++)
                if (puertos.lstMailBox[i].puerto == pPuerto)
                    return i;
            return -1;
        }
        public static int Get_IdxMailBox(string nombre)
        {
            int i;
            for (i = 0; i < puertos.lstMailBox.Count; i++)
                if (puertos.lstMailBox[i].nombre == nombre)
                    return i;
            return -1;
        }
    }
}