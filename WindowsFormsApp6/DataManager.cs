using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp6
{
    class DataManager
    {
        public static List<Performance> Performances = new List<Performance>();
        public static List<User> Users = new List<User>();
       

        static DataManager()
        {
            Load();
        }
        public static void Load()
        {
            try
            {
                string performancesOutput = File.ReadAllText(@"./Performances.xml");
                XElement performancesXElement = XElement.Parse(performancesOutput);

                Performances = (from item in performancesXElement.Descendants("performance")
                                select new Performance()
                                {
                                    Type = item.Element("type").Value,
                                    Number = int.Parse(item.Element("number").Value),
                                    Name = item.Element("name").Value,
                                    Runtime = int.Parse(item.Element("runtime").Value),
                                    Venue = item.Element("venue").Value
                                }).ToList<Performance>();

                string usersOutput = File.ReadAllText(@"./Users.xml");
                XElement usersXElement = XElement.Parse(usersOutput);

                Users = (from item in usersXElement.Descendants("user")
                         select new User()
                         {
                             Type = item.Element("type").Value,
                             Performance_Name = item.Element("performance_name").Value,
                             Tdate = item.Element("tdate").Value,
                             Ttime = item.Element("ttime").Value,
                             Tseat = item.Element("tseat").Value,
                             Price = item.Element("price").Value
                         }).ToList<User>();

             
                ;
            }
            catch (Exception ex)
            {
                Save();
            }
        }
        public static void Save()
        {
            string performancesOutput = "";
            performancesOutput += "<performances>\n";

            foreach (var item in Performances)
            {
                performancesOutput += "<performance>\n";

                performancesOutput += "<type>" + item.Type + "</type>\n";
                performancesOutput += "<number>" + item.Number + "</number>\n";
                performancesOutput += "<name>" + item.Name + "</name>\n";
                performancesOutput += "<runtime>" + item.Runtime + "</runtime>\n";
                performancesOutput += "<venue>" + item.Venue + "</venue>\n";

                performancesOutput += "</performance>\n";
            }
            performancesOutput += "</performances>";

            string usersOutput = "";
            usersOutput += "<users>\n";

            foreach (var item in Users)
            {
                usersOutput += "<user>\n";
             
                usersOutput += "<type>\n" + item.Type + "</type>\n";
                usersOutput += "<performance_name>\n" + item.Performance_Name + "</performance_name>\n";
                usersOutput += "<tdate>\n" + item.Tdate + "</tdate>\n";
                usersOutput += "<ttime>\n" + item.Ttime + "</ttime>\n";
                usersOutput += "<tseat>\n" + item.Tseat + "</tseat>\n";
                usersOutput += "<price>\n" + item.Price + "</price>\n";
                usersOutput += "</user>\n";
            }

            usersOutput += "</users>\n";

            File.WriteAllText(@"./Performances.xml", performancesOutput);
            File.WriteAllText(@"./Users.xml", usersOutput);
        }
    }
}

