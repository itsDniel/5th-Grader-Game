using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace _5th_Grade_Game
{
    public class Questions 
    {

        private string question { get; set; }

        private string questionID { get; set; }

        private string answer1 { get; set; }

        private string answer2 { get; set; }

        private string answer3 { get; set; }

        private string answer4 { get; set; }

        private string correctAnswer { get; set; }

        private string imagePath { get; set; }



        public DataSet qTable()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            return myDataSet;
        }

        public string getQuestion(int index)
        {
            DataSet questionData = new DataSet();
            questionData = qTable();
            question = questionData.Tables[0].Rows[index][1].ToString();
            return question;
        }

        public string getAnswer1(int index)
        {
            DataSet answerData = new DataSet();
            answerData = qTable();
            answer1 = answerData.Tables[0].Rows[index][2].ToString();
            return answer1;
        }

        public string getAnswer2(int index)
        {
            DataSet answerData = new DataSet();
            answerData = qTable();
            answer2 = answerData.Tables[0].Rows[index][3].ToString();
            return answer2;
        }

        public string getAnswer3(int index)
        {
            DataSet answerData = new DataSet();
            answerData = qTable();
            answer3 = answerData.Tables[0].Rows[index][4].ToString();
            return answer3;
        }

        public string getAnswer4(int index)
        {
            DataSet answerData = new DataSet();
            answerData = qTable();
            answer4 = answerData.Tables[0].Rows[index][5].ToString();
            return answer4;
        }

        public string getCorrectAnswer(int index)
        {
            DataSet answerData = new DataSet();
            answerData = qTable();
            correctAnswer = answerData.Tables[0].Rows[index][6].ToString();
            return correctAnswer;
        }

        public string getImage(int index)
        {
            DataSet ImageData = new DataSet();
            ImageData = qTable();
            imagePath = ImageData.Tables[0].Rows[index][7].ToString();
           
            return imagePath;
        }


        //Method to get random numbers to draw random question from the database
        public static int RandNum()
        {
            int num;
            Random rand = new Random();
            num = rand.Next(0, 50);
            return num;
        }


    }
}
