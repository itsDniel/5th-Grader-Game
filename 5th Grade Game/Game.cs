using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5th_Grade_Game
{
    public class Game : Gameplay
    {

        // still a work in progress
        public static string QuestionSequence(int currentIndex)
        {
            string question;
            Questions q = new Questions();
            question = q.getQuestion(currentIndex);
            return question;
        }

        public static string Answer1Sequence(int currentIndex)
        {
            string answer1;
            Questions q = new Questions();
            answer1 = q.getAnswer1(currentIndex);
            return answer1;
        }

        public static string Answer2Sequence(int currentIndex)
        {
            string answer2;
            Questions q = new Questions();
            answer2 = q.getAnswer2(currentIndex);
            return answer2;
        }

        public static string Answer3Sequence(int currentIndex)
        {
            string answer3;
            Questions q = new Questions();
            answer3 = q.getAnswer3(currentIndex);
            return answer3;
        }

        public static string Answer4Sequence(int currentIndex)
        {
            string answer4;
            Questions q = new Questions();
            answer4 = q.getAnswer4(currentIndex);
            return answer4;
        }

        public static string correctAnswerSequence(int currentIndex)
        {
            string correctAnswer;
            Questions q = new Questions();
            correctAnswer = q.getCorrectAnswer(currentIndex);
            return correctAnswer;
        }

        public static string imageFilePath(int currentIndex)
        {
            string imagePath;
            Questions q = new Questions();
            imagePath = q.getImage(currentIndex);
            return imagePath;
        }

        
    }
}
