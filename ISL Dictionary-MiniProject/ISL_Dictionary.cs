using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace CSharp_MiniProject__ISL_Dictionary_
{
    public partial class ISL_Dictionary : Form
    {
        //connect between C# .NET and mySQL
        MySqlConnection sqlcon;
        public ISL_Dictionary()
        {
            InitializeComponent();

            //access mySQL database
            string maincon = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            sqlcon = new MySqlConnection(maincon);
            sqlcon.Open();
        }

        private void ISL_Dictionary_Load(object sender, EventArgs e)
        {
            //================================ X ================================//
                                              /*
            string server = "localhost";
            string database = "isl_dictionary_tb";
            string userid = "root";
            string password = "-";
            ConnectionString = "Server=" + server + ";Database=" + database + ";UserID=" + userid + ";Password=" + password + ";";
                                              */
            //================================ X ================================//
            MySqlCommand wcmd = new MySqlCommand("SELECT dWords FROM vocbulary_tb ORDER BY dWords", sqlcon);
            MySqlDataReader reader = wcmd.ExecuteReader();

            //display list of the items
            while(reader.Read())
                lstISLwords.Items.Add(reader.GetString(0));

            sqlcon.Close();
            //stop accessing the database
        }

        private void lstISLwords_SelectedIndexChanged(object sender, EventArgs e)
        {  
            /*it is difficult to fix how to retrieve videos from database using these programs
            it isn't connecting it to retrieve them. I attempted many times, but it failed. 
            I may not know what keywords are used to mySQL database. 
            */

            
            if(lstISLwords.SelectedItem != null)
            {
                MySqlCommand vcmd = new MySqlCommand("SELECT wVideos, Name from vocbulary_tb WHERE dWord = '"+lstISLwords.Text+"')", sqlcon);
                MySqlDataReader reader = vcmd.ExecuteReader();

                while (reader.Read())
                    WMP_ISLVideos.URL = reader.GetString(2);

                sqlcon.Close();
            }
            

            //it is easy to retrieve the video using array. I need to use mySQL instead of array on C# code.
            //WMP_ISLVideos.URL = @"C:\Users\Asus\Documents\B.Sc Project & Exercises\Programming in C#\CSharp_MiniProject (ISL Dictionary)\ISLVIdeos\1_super_computer.mp4";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //it isn't working to search it, i don't know if it is error or unrelated code
            for (int i = lstISLwords.Items.Count - 1; i >= 0; i++)
            {
                if (lstISLwords.Items[i].ToString().ToLower().Contains(txtSearch.Text.ToLower()))
                {
                    lstISLwords.SetSelected(i, true);
                }
                else
                {
                    MessageBox.Show("No word found", "No Found");
                }
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //control to play video
            WMP_ISLVideos.Ctlcontrols.play();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //control to pause video
            WMP_ISLVideos.Ctlcontrols.pause();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //control to stop video
            WMP_ISLVideos.Ctlcontrols.stop();
        }

       private void btnClose_Click(object sender, EventArgs e)
        {
            //click to exit all apps
            Application.Exit();
        }
    }
}