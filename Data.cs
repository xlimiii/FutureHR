using FutureHR;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutureHR
{
    /*
     Klasa Data służy do pobierania z plików .txt danych kandydatów ubiegających się o stanowisko. Konwertuje dane z pliku na tablice odpowiednich obiektów.
         */
    class Data
    {
        public static List<Person> HumanCandidates { get { return UploadHumanCandidates("people.txt"); } }
        public static List<Robot> RobotCandidates { get { return UploadRobotsCandidates("robots.txt"); } }
        public static List<RobotForInterviewAdapter> RobotAdapters {get { return UploadRobotsForInterviewAdapters(); } }

        private static List<Person> UploadHumanCandidates(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<Person> candidates = new List<Person>();
            double[][] tab = new double[lines.Length - 1][];     
            
            for (int i = 0; i < lines.Length; i++)
            {
                string[] tmp = lines[i].Split('|');
                candidates.Add(new Person());
                candidates[i].FirstName = tmp[0];
                candidates[i].LastName = tmp[1];
                candidates[i].Age = Convert.ToInt32(tmp[2]);
                string[] tmp2 = tmp[3].Split(',');
                List<string> features = new List<string>();
                for(int j=0; j < tmp2.Length; j++)
                {
                    features.Add(tmp2[j]);
                }
                candidates[i].Feature = features;
            }
            return candidates;
        }

        private static List<Robot> UploadRobotsCandidates(string path)
        {
            string[] lines = File.ReadAllLines(path);
            List<Robot> candidates = new List<Robot>();
            double[][] tab = new double[lines.Length - 1][];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] tmp = lines[i].Split('|');
                candidates.Add(new Robot());
                candidates[i].Model = tmp[0];
                candidates[i].SerialNumber = Convert.ToInt32(tmp[1]);
                candidates[i].ProductionDate = new DateTime(Convert.ToInt32(tmp[2]), Convert.ToInt32(tmp[3]), Convert.ToInt32(tmp[4]));
                candidates[i].ComputingPower = Convert.ToInt32(tmp[5]);
                candidates[i].CoreNumbers = Convert.ToInt32(tmp[6]);
                candidates[i].BatteryLife = Convert.ToInt32(tmp[7]);
                candidates[i].ID = Convert.ToInt32(tmp[8]);
            }
            return candidates;
        }
        private static List<RobotForInterviewAdapter> UploadRobotsForInterviewAdapters()
            {
            List<RobotForInterviewAdapter> rfia = new List<RobotForInterviewAdapter>();
                foreach (Robot robot in RobotCandidates)
                {
                RobotForInterviewAdapter r = new RobotForInterviewAdapter(robot);
                rfia.Add(r);
                }
            return rfia;
            }
    }
}
