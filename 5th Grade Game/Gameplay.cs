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
    public partial class Gameplay : Form
    {
        OleDbConnection myConnection;
        OleDbDataAdapter myDataAdapter;
        DataSet playerDataSet;
        BindingSource myBind;
        string strSQL;
        public string _textbox
        {
            set { labelTest.Text = value; }
        }

        public string _ageTest
        {
            set { labelAgeTest.Text = value; }
        }
        int currentIndex = 1;
        int score = 0;
        List<int> listnum = new List<int>();

        public Gameplay()
        {
            InitializeComponent();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            int num;
            num = Questions.RandNum();

            if (listnum.Contains(num))
            {
                btnNext.PerformClick();
            }
            else
            {
                listnum.Add(num);
                lblQuestion.Text = Game.QuestionSequence(num);
                btnQ1.Text = Game.Answer1Sequence(num);
                btnQ2.Text = Game.Answer2Sequence(num);
                btnQ3.Text = Game.Answer3Sequence(num);
                btnQ4.Text = Game.Answer4Sequence(num);

                hiddenlbl.Text = Game.correctAnswerSequence(num);
                hiddenlbl.Hide();

                pbImage.ImageLocation = Game.imageFilePath(num);
                currentIndex++;

                if (currentIndex == 10)
                {
                    // once the game ends, everything gets sent over to the database

                    myBind.SuspendBinding();

                    DataTable dtPlayers = playerDataSet.Tables["PlayerTable"];
                    DataRow drNewPlayer = dtPlayers.NewRow();

                    string b = labelTest.Text;
                    string c = labelAgeTest.Text;

                    Console.WriteLine(b);
                    drNewPlayer["PlayerName"] = b;
                    drNewPlayer["PlayerAge"] = c;
                    drNewPlayer["PlayerScore"] = lblScore.Text;

                    dtPlayers.Rows.Add(drNewPlayer);

                    myBind.ResumeBinding();

                    OleDbCommandBuilder builder = new OleDbCommandBuilder(myDataAdapter);
                    myDataAdapter.Update(playerDataSet, "PlayerTable");

                    this.Hide();
                    if(score < 7)
                    {
                        MessageBox.Show("You scored: " + score + " points, guess you not that smart after all");
                    }
                    else
                    {
                        MessageBox.Show("You scored: " + score + " points, congrat you are indeed smarter than a 5th grader");
                    }

                    GameInfo re = new GameInfo();
                    re.ShowDialog();
                }
            }

        }

        public void Gameplay_Load(object sender, EventArgs e)
        {
            myConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;Data Source = Questions.accdb");
            strSQL = "SELECT * FROM Player";
            myDataAdapter = new OleDbDataAdapter(strSQL, myConnection);
            playerDataSet = new DataSet("PlayerTable");
            myDataAdapter.Fill(playerDataSet, "PlayerTable");

            myBind = new BindingSource();
            myBind.DataSource = playerDataSet;
            myBind.DataMember = "PlayerTable";

            int num;
            num = Questions.RandNum();

            lblQuestion.Text = Game.QuestionSequence(num);
            btnQ1.Text = Game.Answer1Sequence(num);
            btnQ2.Text = Game.Answer2Sequence(num);
            btnQ3.Text = Game.Answer3Sequence(num);
            btnQ4.Text = Game.Answer4Sequence(num);

            hiddenlbl.Text = Game.correctAnswerSequence(num);
            hiddenlbl.Hide();

            pbImage.ImageLocation = Game.imageFilePath(num);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btnQ1.Text == hiddenlbl.Text)
            {
                MessageBox.Show("Congratulation!!!");
                Console.WriteLine("User got question right!");
                score++;
                lblScore.Text = score.ToString();
                btnNext.PerformClick();
            }
            else
            {
                MessageBox.Show("Wrong Answer!!!");
                btnNext.PerformClick();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (btnQ2.Text == hiddenlbl.Text)
            {
                MessageBox.Show("Congratulation!!!");
                score++;
                lblScore.Text = score.ToString();
                btnNext.PerformClick();
            }
            else
            {
                MessageBox.Show("Wrong Answer!!!");
                btnNext.PerformClick();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (btnQ3.Text == hiddenlbl.Text)
            {
                MessageBox.Show("Congratulation!!!");
                score++;
                lblScore.Text = score.ToString();
                btnNext.PerformClick();
            }
            else
            {
                MessageBox.Show("Wrong Answer!!!");
                btnNext.PerformClick();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (btnQ4.Text == hiddenlbl.Text)
            {
                MessageBox.Show("Congratulation!!!");
                score++;
                lblScore.Text = score.ToString();
                btnNext.PerformClick();
            }
            else
            {
                MessageBox.Show("Wrong Answer!!!");
                btnNext.PerformClick();
            }
        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
