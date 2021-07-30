using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace Projekt.Model
{
    public class downloader
    {
        /// <summary>
        /// default construktor
        /// </summary>
        public downloader()
        {

        }
        /// <summary>
        /// Methode für laden der Daten von der CSV Datei
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public string[] LoadData(string path)
        {
            string[] allData = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            return allData;

        }
        /// <summary>
        /// Methode zum Teilen der einzelnen Daten
        /// </summary>
        /// <param name="allData"></param>
        /// <param name="indices"></param>
        /// <returns></returns>
        public string[] Split(string[] allData, int indices)
        {
            string[] datarow;

            datarow = allData[indices].Split(';');

            return datarow;
        }

    }



}
