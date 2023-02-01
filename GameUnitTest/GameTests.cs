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
    public class GameTests
    {
        [TestMethod()]
        public void QuestionSequenceTest()
        {
            string actualQuestion1 = "What planet is this?";
            string actualQuestion2 = "What continent is this?";
            string testQuestion1, testQuestion2;
            Questions q = new Questions();
            testQuestion1 = q.getQuestion(0);
            testQuestion2 = q.getQuestion(1);

            //Test to ensure the return questions are not null
            Assert.IsNotNull(testQuestion1);
            Assert.IsNotNull(testQuestion2);

            //Test to ensure the return questions are correct based on the given index
            Assert.AreEqual(testQuestion1, actualQuestion1);
            Assert.AreEqual(testQuestion2, actualQuestion2);
        }

        [TestMethod()]
        public void Answer1SequenceTest()
        {
            string actualAnswer1 = "Mars";
            string actualAnswer2 = "South America";
            string testAnswer1, testAnswer2;
            Questions q = new Questions();
            testAnswer1 = q.getAnswer1(0);
            testAnswer2 = q.getAnswer1(1);

            //Test to ensure the return questions are not null
            Assert.IsNotNull(testAnswer1);
            Assert.IsNotNull(testAnswer2);

            //Test to ensure the return questions are correct based on the given index
            Assert.AreEqual(testAnswer1, actualAnswer1);
            Assert.AreEqual(testAnswer2, actualAnswer2);
        }

        [TestMethod()]
        public void Answer2SequenceTest()
        {
            string actualAnswer1 = "Earth";
            string actualAnswer2 = "Africa";
            string testAnswer1, testAnswer2;
            Questions q = new Questions();
            testAnswer1 = q.getAnswer2(0);
            testAnswer2 = q.getAnswer2(1);

            //Test to ensure the return questions are not null
            Assert.IsNotNull(testAnswer1);
            Assert.IsNotNull(testAnswer2);

            //Test to ensure the return questions are correct based on the given index
            Assert.AreEqual(testAnswer1, actualAnswer1);
            Assert.AreEqual(testAnswer2, actualAnswer2);
        }

        [TestMethod()]
        public void Answer3SequenceTest()
        {
            string actualAnswer1 = "Saturn";
            string actualAnswer2 = "North America";
            string testAnswer1, testAnswer2;
            Questions q = new Questions();
            testAnswer1 = q.getAnswer3(0);
            testAnswer2 = q.getAnswer3(1);

            //Test to ensure the return questions are not null
            Assert.IsNotNull(testAnswer1);
            Assert.IsNotNull(testAnswer2);

            //Test to ensure the return questions are correct based on the given index
            Assert.AreEqual(testAnswer1, actualAnswer1);
            Assert.AreEqual(testAnswer2, actualAnswer2);
        }

        [TestMethod()]
        public void Answer4SequenceTest()
        {
            string actualAnswer1 = "Venus";
            string actualAnswer2 = "Asia";
            string testAnswer1, testAnswer2;
            Questions q = new Questions();
            testAnswer1 = q.getAnswer4(0);
            testAnswer2 = q.getAnswer4(1);

            //Test to ensure the return questions are not null
            Assert.IsNotNull(testAnswer1);
            Assert.IsNotNull(testAnswer2);

            //Test to ensure the return questions are correct based on the given index
            Assert.AreEqual(testAnswer1, actualAnswer1);
            Assert.AreEqual(testAnswer2, actualAnswer2);
        }

        [TestMethod()]
        public void correctAnswerSequenceTest()
        {
            string actualAnswer1 = "Mars";
            string actualAnswer2 = "North America";
            string testAnswer1, testAnswer2;
            Questions q = new Questions();
            testAnswer1 = q.getCorrectAnswer(0);
            testAnswer2 = q.getCorrectAnswer(1);

            //Test to ensure the return questions are not null
            Assert.IsNotNull(testAnswer1);
            Assert.IsNotNull(testAnswer2);

            //Test to ensure the return questions are correct based on the given index
            Assert.AreEqual(testAnswer1, actualAnswer1);
            Assert.AreEqual(testAnswer2, actualAnswer2);
        }

        [TestMethod()]
        public void imageFilePathTest()
        {
            string actualImagePath1 = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0e/Tharsis_and_Valles_Marineris_-_Mars_Orbiter_Mission_%2830055660701%29.png/220px-Tharsis_and_Valles_Marineris_-_Mars_Orbiter_Mission_%2830055660701%29.png";
            string actualImagePath2 = "https://upload.wikimedia.org/wikipedia/commons/thumb/4/43/Location_North_America.svg/220px-Location_North_America.svg.png";
            string testImagePath1, testImagePath2;
            Questions q = new Questions();
            testImagePath1 = q.getImage(0);
            testImagePath2 = q.getImage(1);

            //Test to ensure the return images are not null
            Assert.IsNotNull(testImagePath1);
            Assert.IsNotNull(testImagePath2);

            //Test to ensure the return images are correct based on the given index
            Assert.AreEqual(testImagePath1, actualImagePath1);
            Assert.AreEqual(testImagePath2, actualImagePath2);
        }
    }
}