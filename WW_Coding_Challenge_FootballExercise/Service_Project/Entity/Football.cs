using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Project.Entity
{
    /**
     * This class contains information about a match result , which store information for a row in the input file.
     */ 
    public class Football
    {
        public string Team { get; set; }
        public int P { get; set; }
        public int W { get; set; }
        public int L { get; set; }
        public int D { get; set; }
        public int F { get; set; }
        public string Hyphen { get; set; }
        public int A { get; set; }
        public int Pts { get; set; }
        public bool isValid{ get; set; }
        
        public Football(object team, object p, object w, object l, object d, object f, object hyphen, object a, object pts)
        { 
            
            // valid all the tokens in the line if format is right.
            isValid=validateColumnDataValid(team, p,w,l,d,f, a,pts);

            // if all columns are valid 
            if(isValid)
            { 
                Team= team.ToString();
                P=int.Parse(p.ToString());
                W=int.Parse(w.ToString());
                L=int.Parse(l.ToString());
                D=int.Parse(d.ToString());
                F=int.Parse(f.ToString());
                Hyphen=hyphen.ToString();
                A=int.Parse(a.ToString());
                Pts=int.Parse(pts.ToString());
            }
        }

        private bool validateColumnDataValid(object team, object p, object w, object l, object d, object f, object a, object pts)
        {

             return Util.IfDataMatchType(team,typeof(string)) && Util.IfDataMatchType(p,typeof(int)) && 
                Util.IfDataMatchType(w,typeof(int)) && Util.IfDataMatchType(l,typeof(int)) && 
                Util.IfDataMatchType(d,typeof(int)) && Util.IfDataMatchType(f,typeof(int)) &&
                Util.IfDataMatchType(a,typeof(int)) && 
                Util.IfDataMatchType(pts,typeof(int)); 
        }
    }
}
