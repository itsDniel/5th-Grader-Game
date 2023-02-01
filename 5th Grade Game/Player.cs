using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace _5th_Grade_Game
{
    class Player
    {
        private string name { get; set; }
        private int age { get; set; }
        private int score { get; set; }


        public Player(string name, int age, int score)
        {
            this.name = name;
            this.age = age;
            this.score = score;
        }

        public DataSet playerTable()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Player";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("PlayerTable");
            myDataAdapter.Fill(myDataSet, "PlayerTable");

            return myDataSet;
        }

        public string GetPlayer(int index)
        {
            DataSet playerData = new DataSet();
            playerData = playerTable();
            name = playerData.Tables[0].Rows[index][1].ToString();
            return name;
        }

        public int GetPlayerAge(int index)
        {
            DataSet playerData = new DataSet();
            playerData = playerTable();
            age = Convert.ToInt32(playerData.Tables[0].Rows[index][2].ToString());
            return age;
        }

        public int GetPlayerScore(int index)
        {
            DataSet playerData = new DataSet();
            playerData = playerTable();
            score = Convert.ToInt32(playerData.Tables[0].Rows[index][3].ToString());
            return score;
        }

    }
}
