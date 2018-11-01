using Service_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project
{
    public class InputFile
    {
        public string sFilePath { get; set; }
        public List<string> lstLines { get; set; }
        public List<ErrorMesage> lstErrorMessage{ get; set; }
        public FileSettings fileFormatSettings = new FileSettings();
        
        public InputFile(string fileName)
        {   
            sFilePath = fileName;
            lstLines = Util.ReadFileByName(fileName);
            lstErrorMessage = new List<ErrorMesage>();
        }
    }
}
