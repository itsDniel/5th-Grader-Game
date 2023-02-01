using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5th_Grade_Game
{
    public partial class Leaderboard : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet playerDataSet;
        DataTable playerTable;
        string strSQL;
        public Leaderboard()
        {
            InitializeComponent();
        }

        private void Leaderboard_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            strSQL = "SELECT * FROM Player";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            playerDataSet = new DataSet("PlayerTable");
            myDataAdapter.Fill(playerDataSet, "PlayerTable");

            playerTable = playerDataSet.Tables["PlayerTable"];
            dgvLeaderBoard.DataSource = playerTable;
            this.dgvLeaderBoard.Columns["PlayerID"].Visible = false;
            dgvLeaderBoard.Sort(dgvLeaderBoard.Columns["PlayerScore"], ListSortDirection.Descending);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameInfo info = new GameInfo();
            info.ShowDialog();
        }
    }
}
