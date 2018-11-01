using Service_Project.Entity;
using System.Collections.Generic;

namespace Service_Project
{
    public interface ITALFile
    {
        bool validateFileContent();
        void initFileFormatSettings();
        List<Football> getListData();
        List<ErrorMesage> getListDataError();
    }
}