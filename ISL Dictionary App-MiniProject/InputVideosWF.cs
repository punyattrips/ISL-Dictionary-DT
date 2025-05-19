using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.IO;

namespace CSharp_MiniProject__ISL_Dictionary_
{
    public partial class InputVideosWF : Form
    {
        MySqlConnection con;
        public InputVideosWF()
        {
            InitializeComponent();
            string maincon = ConfigurationManager.ConnectionStrings["myDatabaseConnection"].ConnectionString;
            con = new MySqlConnection(maincon);
            con.Open();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                lstWords.Items.Add(openFileDialog.FileName);

            MySqlCommand cmd = new MySqlCommand("INSERT into vocbulary_tb values('" + Guid.NewGuid() + "', '" + txtWords + "', '" + openFileDialog + "', @content)", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lstWords.Items.Add(reader.GetString(0));
                lstWords.Items.Add(openFileDialog.FileName);
            }
            con.Close();
        }

        private string GetFromDataBase(string fileName)
        {
            try
            {
                MySqlConnection myConnection = new MySqlConnection("myDatabaseConnection");
                String Query1 = "SELECT wVideos FROM vocabulary_tb where FileName = '" + fileName + "'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query1, "myDatabaseConnection");
                DataSet Ds = new DataSet();
                adapter.Fill(Ds, "sVideos");
                if (Ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No data Found");
                    return string.Empty;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return string.Empty;
        }

        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            if (lstWords.SelectedItem == null)
            {
                MessageBox.Show("Please select file to play."); return;
            }
            axWMP_ISL.URL = GetFromDataBase(lstWords.SelectedItem.ToString());
            axWMP_ISL.settings.autoStart = true;
        }
    }
}
