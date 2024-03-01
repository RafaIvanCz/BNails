using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
using System.Data;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Common.Conversiones_explicitas
{
    public class Conversiones
    {
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }
        //Funcion que cambia el punto por la coma y elimina espacios y simbolo $
        public static decimal Convertir_ValorMonetario_aDecimal(string valor)
        {
            string cadena = valor.Replace(" ", "");
            cadena = cadena.Replace(".", ",");
            cadena = cadena.Replace("$", "");

            return(Convert.ToDecimal(cadena));
        }
        
        public static string Normalizar_CadenaTexto(string cadena_original)
        {
            string textoNormalizado = cadena_original.Normalize(NormalizationForm.FormD);
            Regex reg = new Regex("[^a-zA-Z0-9 ]");
            string textoSinAcentos = reg.Replace(textoNormalizado, "");
            return textoSinAcentos;
        }

    }
}
