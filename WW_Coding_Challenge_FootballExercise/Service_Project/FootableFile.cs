using Service_Project.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WW_Coding_Challenge_FootballExercise.Constants;

namespace Service_Project
{
    public class FootableFile: InputFile,ITALFile
    {
        public bool IsFileValid{ get; set; }

        // list of the row objects
        public List<Football> listFootable{ get; set; }
        
        // pass the filename to parent class, which will handle read file and validation
        public FootableFile(string fileName):base(fileName)
        { 
            listFootable = new List<Football>();            
            // init the file setting
            initFileFormatSettings();
            
        }
       
        public void initFileFormatSettings()
        { 
            string fileExt = Path.GetExtension(base.sFilePath);
            if(fileExt.Equals(".csv"))
            {
                fileFormatSettings.sSplitToken=", .";
                fileFormatSettings.bIfHeaderInFirstLine=true;
                fileFormatSettings.iTokensPerCol=10;
            }
            else if(fileExt.Equals(".dat"))
            {
                fileFormatSettings.sSplitToken="  ";
                fileFormatSettings.bIfHeaderInFirstLine=true;
                fileFormatSettings.iTokensPerCol=10;
            }
        }


        public bool validateFileContent()
        {
            IsFileValid=true;
            bool isLineValid;
            
            for (int i = 0; i < lstLines.Count; i++)
            {
                if(fileFormatSettings.bIfHeaderInFirstLine && i== 0) continue;

                isLineValid=true;
                string mesg=string.Empty;                
                string line = lstLines[i];                
                List<string> lineData = line.Split(fileFormatSettings.sSplitToken.ToCharArray()).ToList();
                lineData = lineData.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();
                
                ErrorMesage erroMsgObj;

                if(lineData.Count!=fileFormatSettings.iTokensPerCol)
                { 
                    mesg=AppConstant.ERROR_TOKEN_COUNT_MISMATCH;;
                    mesg=string.Format(mesg,fileFormatSettings.iTokensPerCol);
                    isLineValid=false;                    
                }  
                else
                { 
                    Football newFootableRecord=  new Football(lineData[1],lineData[2],lineData[3],lineData[4],lineData[5],lineData[6], lineData[7],lineData[8],lineData[9]);
                    if(newFootableRecord.isValid)
                    { 
                        listFootable.Add(newFootableRecord);
                        isLineValid=true;   
                    }
                    else{ 
                        mesg=AppConstant.ERROR_FIELD_TYPE_MISMATCH;

                        isLineValid=false;
                    }
                }              
                if(!isLineValid)
                { 
                    IsFileValid=false;
                    erroMsgObj = new ErrorMesage();
                    erroMsgObj.sErrorMessage= mesg;
                    erroMsgObj.sLineText=line;
                    erroMsgObj.iCurLineNo=i;
                    lstErrorMessage.Add(erroMsgObj);
                }
            }
            
            return IsFileValid;
        }

        public List<Football> getListData()
        {
           return listFootable;
        }
        public List<ErrorMesage> getListDataError()
        {
           return lstErrorMessage;
        }
    }
}
