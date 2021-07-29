using Projekt.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    public class ConfigModel
    {
        private List<AllData> burgenland;
        private List<AllData> carinthia;
        private List<AllData> lowerAustria;
        private List<AllData> upperAustria;
        private List<AllData> salzburg;
        private List<AllData> styria;
        private List<AllData> tyrol;
        private List<AllData> vorarlberg;
        private List<AllData> vienna;
        private List<AllData> austria;
        private List<List<AllData>> tempList;

        public ConfigModel()
        {
            burgenland = new List<AllData>();
            carinthia = new List<AllData>();
            lowerAustria = new List<AllData>();
            upperAustria = new List<AllData>();
            salzburg = new List<AllData>();
            styria = new List<AllData>();
            tyrol = new List<AllData>();
            vorarlberg = new List<AllData>();
            vienna = new List<AllData>();
            austria = new List<AllData>();
            tempList = new List<List<AllData>>();
        }
        public void organizeAndSafe(AllData allData)
        {
            if (allData.Id == 1)
            {
                burgenland.Add(allData);
            }
            if (allData.Id == 2)
            {
                carinthia.Add(allData);
            }
            if (allData.Id == 3)
            {
                lowerAustria.Add(allData);
            }
            if (allData.Id == 4)
            {
                upperAustria.Add(allData);
            }
            if (allData.Id == 5)
            {
                salzburg.Add(allData);
            }
            if (allData.Id == 6)
            {
                styria.Add(allData);
            }
            if (allData.Id == 7)
            {
                tyrol.Add(allData);
            }
            if (allData.Id == 8)
            {
                vorarlberg.Add(allData);
            }
            if (allData.Id == 9)
            {
                vienna.Add(allData);
            }
            if (allData.Id == 10)
            {
                austria.Add(allData);
            }

        }
        public bool existence(string text)
        {
            if (text == burgenland[0].country || text == carinthia[0].country ||
                text == lowerAustria[0].country || text == upperAustria[0].country ||
                text == salzburg[0].country || text == styria[0].country ||
                text == tyrol[0].country || text == vorarlberg[0].country || text == vienna[0].country ||
                text == austria[0].country)
            {
                return true;
            }
            else
            {

                return false;
            }
        }
        public List<List<AllData>> findListForExport(List<string> countryList)
        {
            tempList.Clear();
            foreach (var item in countryList)
            {
                if (item == burgenland[0].country)
                {
                    tempList.Add(burgenland);
                }
                if (item == carinthia[0].country)
                {
                    tempList.Add(carinthia);
                }
                if (item == lowerAustria[0].country)
                {
                    tempList.Add(lowerAustria);
                }
                if (item == upperAustria[0].country)
                {
                    tempList.Add(upperAustria);
                }
                if (item == salzburg[0].country)
                {
                    tempList.Add(salzburg);
                }
                if (item == tyrol[0].country)
                {
                    tempList.Add(tyrol);
                }
                if (item == vorarlberg[0].country)
                {
                    tempList.Add(vorarlberg);
                }
                if (item == vienna[0].country)
                {
                    tempList.Add(vienna);
                }
                if (item == styria[0].country)
                {
                    tempList.Add(styria);
                }
                if (item == austria[0].country)
                {
                    tempList.Add(austria);
                }
            }
            return tempList;

        }
        public void Clear()
        {
            if (burgenland != null)
            {
                burgenland.Clear();
                carinthia.Clear();
                lowerAustria.Clear();
                upperAustria.Clear();
                salzburg.Clear();
                styria.Clear();
                tyrol.Clear();
                vorarlberg.Clear();
                vienna.Clear();
                austria.Clear();
            }
        }

    }
}
