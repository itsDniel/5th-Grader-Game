using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace _5th_Grade_Game
{
    public partial class GameInfo : Form
    {
        public string _nameBox
        {
            get { return txtName.Text; }
        }

        public string _ageBox
        {
            get { return txtAge.Text; }
        }
        

        public GameInfo()
        {
            InitializeComponent();
        }

        private void GameInfo_Load(object sender, EventArgs e){}



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void playbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Gameplay g = new Gameplay();
            g._textbox = _nameBox;
            g._ageTest = _ageBox;
            g.ShowDialog();
        }


        private void nametxt_TextChanged_1(object sender, EventArgs e)
        {
            if (txtName.Text != String.Empty)
            {
                btnPlay.Enabled = true;
            }
            else
            {
                btnPlay.Enabled = false;
            }
        }

        private void leaderboardbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Leaderboard lb = new Leaderboard();
            lb.ShowDialog();
        }
        
        
    }
}
