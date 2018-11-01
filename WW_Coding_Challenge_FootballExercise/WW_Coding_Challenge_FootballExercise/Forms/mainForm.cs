using Service_Project;
using Service_Project.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WW_Coding_Challenge_FootballExercise
{
    public partial class mainForm : Form
    {
        private string curSelectedType="", filePath="";
        
        private ITALFile curLoadFile=null;
        
        public mainForm()
        {
            InitializeComponent();
            lblAssumption.Text="I have made the assumption in order to get the difference in 'for' and 'against'\n, the formulae is column F - A";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmFileName.SelectedIndex=0;
            
        }

        private void LoadFile(object sender, EventArgs e)
        {
           filePath= cmFileName.Text;
            
           curLoadFile =  new FootableFile(filePath);
           
           curLoadFile.validateFileContent();          
            
           dgReadResult.DataSource= curLoadFile.getListData();                           
           dgErrorResult.DataSource=curLoadFile.getListDataError();
            FindSmallestFAResult();
            
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            filePath= cmFileName.Text;
            btnLoadFile.Enabled = cmFileName.Text.Length >0 && cmFileName.Text.IndexOf(".")>0;
            
        }


        private void FindSmallestFAResult()
        {
            List<Football> lstFootableData= curLoadFile.getListData();
            Football smallRestRecord=null;
            int smallest=0;
            foreach (Football item in lstFootableData)
            {
                int diff= item.F-item.A;
                if(diff<smallest)
                { 
                    smallest=diff;    
                    smallRestRecord= item;
                }

            }
            lblTeamResult.Text=smallRestRecord.Team;
            lblFResult.Text=smallRestRecord.F.ToString();
            lblAResult.Text=smallRestRecord.A.ToString();
            lblDiffResult.Text=smallest.ToString();

        }

       
        

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutAuthor about = new AboutAuthor();
            about.ShowDialog();
        }

    }
}
