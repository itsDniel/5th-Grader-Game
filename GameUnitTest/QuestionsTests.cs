using Microsoft.VisualStudio.TestTools.UnitTesting;
using _5th_Grade_Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;



namespace _5th_Grade_Game.Tests
{
    [TestClass()]
    public class QuestionsTests
    {
        [TestMethod()]

        public void qTableTest()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            int expectedID = 1;
            int actualID = int.Parse(myDataSet.Tables[0].Rows[0][0].ToString());


            //Test to ensure the data set is not null
            Assert.IsNotNull(myDataSet);

            //Test to ensure the data set contain the correct database table
            Assert.AreEqual(expectedID, actualID);

        }

        [TestMethod()]
        public void getQuestionTest()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            string testQuestion = "What planet is this?";

            string actualQuestion;
            actualQuestion = myDataSet.Tables[0].Rows[0][1].ToString();

            //Test to ensure the return question is not null
            Assert.IsNotNull(actualQuestion);

            //Test to ensure the return question is the correct one
            Assert.AreEqual(testQuestion, actualQuestion);

        }

        [TestMethod()]
        public void getAnswer1Test()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            string testAnswer1 = "Mars";
            string actualAnswer1 = myDataSet.Tables[0].Rows[0][2].ToString();

            //Test to ensure the return answer is not null
            Assert.IsNotNull(actualAnswer1);


            //Test to ensure the return answer is the correct one
            Assert.AreEqual(testAnswer1, actualAnswer1);
        }

        [TestMethod()]
        public void getAnswer2Test()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            string testAnswer2 = "Earth";
            string actualAnswer2 = myDataSet.Tables[0].Rows[0][3].ToString();

            //Test to ensure the return answer is not null
            Assert.IsNotNull(actualAnswer2);

            //Test to ensure the return answer is the correct one
            Assert.AreEqual(testAnswer2, actualAnswer2);
        }

        [TestMethod()]
        public void getAnswer3Test()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            string testAnswer3 = "Saturn";
            string actualAnswer3 = myDataSet.Tables[0].Rows[0][4].ToString();

            //Test to ensure the return answer is not null
            Assert.IsNotNull(actualAnswer3);

            //Test to ensure the return answer is the correct one
            Assert.AreEqual(testAnswer3, actualAnswer3);
        }

        [TestMethod()]
        public void getAnswer4Test()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            string testAnswer4 = "Venus";
            string actualAnswer4 = myDataSet.Tables[0].Rows[0][5].ToString();

            //Test to ensure the return answer is not null
            Assert.IsNotNull(actualAnswer4);

            //Test to ensure the return answer is the correct one
            Assert.AreEqual(testAnswer4, actualAnswer4);
        }

        [TestMethod()]
        public void getCorrectAnswerTest()
        {
            OleDbConnection strConnection = new OleDbConnection("provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Questions.accdb");
            string strSQL = "SELECT * FROM Question";
            OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(strSQL, strConnection);
            DataSet myDataSet = new DataSet("QuestionTable");
            myDataAdapter.Fill(myDataSet, "QuestionTable");

            string testCorrectAnswer = "Mars";
            string actualCorrectAnswer = myDataSet.Tables[0].Rows[0][6].ToString();

            //Test to ensure the return answer is not null
            Assert.IsNotNull(actualCorrectAnswer);

            //Test to ensure the return answer is the correct one
            Assert.AreEqual(testCorrectAnswer, actualCorrectAnswer);
        }

        [TestMethod()]
        public void RandNumTest()
        {
            int testNum;
            testNum = Questions.RandNum();

            //Test to ensure the return list is not null
            Assert.IsNotNull(testNum);




        }
    }


}