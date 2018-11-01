using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project.Entity
{
    /**
     * This class contains error details in the lines in the file
     * sErrorMessage - customize error message
     * sLineText - current line text
     * iCurLineNo - line number in the file
     */
    public class ErrorMesage
    {
        public string sErrorMessage{ get; set; }
        public string sLineText{ get; set; }
        public int iCurLineNo { get; set; }
    }
}
