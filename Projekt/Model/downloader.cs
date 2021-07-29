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
        public downloader()
        {

        }
        public string[] LoadData(string path)
        {
            string[] allData = File.ReadAllLines(path, System.Text.Encoding.UTF8);
            return allData;

        }
        public string[] Split(string[] allData, int indices)
        {
            string[] datarow;

            datarow = allData[indices].Split(';');

            return datarow;
        }

    }


    
}
