using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project
{
    public class Util
    {
        public static List<string> ReadFileByName(string sFileName)
        {
            List<string> listLines = new List<string>();
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file = new System.IO.StreamReader(sFileName);
            while ((line = file.ReadLine()) != null)
            {
                listLines.Add(line);
            }

            file.Close();
            return listLines;
        }
        public static bool IfDataMatchType(object curValue, Type curType)
        { 
            bool isValid;
            if(curType==typeof(int))
             { 
                int p;
                isValid= int.TryParse(curValue.ToString(),out p);
                  
             }
             else{
                isValid = curValue.GetType() ==curType;
            }
            return isValid;
        }
    }
}
