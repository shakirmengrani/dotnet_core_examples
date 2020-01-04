using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace QuizManager.Data
{
    public class QuizService
    {
        protected static List<QuizItem> Questions;
        static QuizService(){
            Questions = new List<QuizItem> {
                new QuizItem{
                    Question = "What is CPU",
                    Choices = new List<string>{"compute processing unit", "communication programing unit", "central processing unit"},
                    AnswerIndex = 2,
                    Score = 10
                }
            };
        }

        public Task<List<QuizItem>> GetQuizAsync(){
            return Task.FromResult(Questions);
        }
    }
}