using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Web
{
    public class Notificaciones
    {
        /// <summary>
        /// Dada una fecha, se compara con la fecha actual y retorna un texto indicativo de 
        /// cuantos años, o meses, días, horas, minutos o segundos transcurrieron desde la fecha
        /// de entrada a la fecha actual
        /// </summary>
        /// <param name="mensaje"></param>
        /// <param name="fecha"></param>
        /// <returns></returns>
        public static string getTimeLeftText(DateTime fecha)
        {
            string valor = string.Empty;
            try
            {
                DateTime fechaActual = DateTime.Now;
                if (fecha.Year < fechaActual.Year) //Comparo el año
                {
                    if ((fechaActual.Year - fecha.Year) == 1)
                        valor = "Hace " + (fechaActual.Year - fecha.Year).ToString() + " año";
                    else
                        valor = "Hace " + (fechaActual.Year - fecha.Year).ToString() + " años";
                }
                else
                {
                    if (fecha.Month < fechaActual.Month) //Comparo los meses
                    {
                        if ((fechaActual.Month - fecha.Month) == 1)
                            valor = "Hace " + (fechaActual.Month - fecha.Month).ToString() + " mes";
                        else
                            valor = "Hace " + (fechaActual.Month - fecha.Month).ToString() + " meses";
                    }
                    else
                    {
                        if (fecha.Day < fechaActual.Day) //Comparo días
                        {
                            if ((fechaActual.Day - fecha.Day) == 1)
                                valor = "Hace " + (fechaActual.Day - fecha.Day).ToString() + " día";
                            else
                                valor = "Hace " + (fechaActual.Day - fecha.Day).ToString() + " días";
                        }
                        else
                        {
                            if (fecha.Hour < fechaActual.Hour)
                            {
                                if ((fechaActual.Hour - fecha.Hour) == 1)
                                    valor = "Hace " + (fechaActual.Hour - fecha.Hour).ToString() + " hora";
                                else
                                    valor = "Hace " + (fechaActual.Hour - fecha.Hour).ToString() + " horas";
                            }
                            else
                            {
                                if (fecha.Minute < fechaActual.Minute)
                                {
                                    if ((fechaActual.Minute - fecha.Minute) == 1)
                                        valor = "Hace " + (fechaActual.Minute - fecha.Minute).ToString() + " minuto";
                                    else
                                        valor = "Hace " + (fechaActual.Minute - fecha.Minute).ToString() + " minutos";
                                }
                                else
                                {
                                    if (fecha.Second < fechaActual.Second)
                                    {
                                        if ((fechaActual.Second - fecha.Second) == 1)
                                            valor = "Hace " + (fechaActual.Second - fecha.Second).ToString() + " segundo";
                                        else
                                            valor = "Hace " + (fechaActual.Second - fecha.Second).ToString() + " segundos";
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return valor;
        }
    }
}
