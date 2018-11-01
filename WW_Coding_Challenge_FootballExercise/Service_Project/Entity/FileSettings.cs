using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project.Entity
{
    /**
     * This class contains some settings to the input file
     * 
     * iTokensPerCol - how many information we need to grab in a line
     * sSplitToken - data in the file is split by 
     * bIfHeaderInFirstLine - if first line of the file is a header, if yes will skip it
     */
    public class FileSettings
    {
        public int iTokensPerCol{ get; set; }
        public string sSplitToken { get; set; }
        public bool bIfHeaderInFirstLine { get; set; }
    }
}
