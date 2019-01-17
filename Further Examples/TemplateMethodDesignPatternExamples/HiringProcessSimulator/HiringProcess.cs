using System;

namespace HiringProcessSimulator
{
    public abstract class HiringProcess
    {
        public void HireRefreshers()
        {
            FirstRoundTest();
            GroupDiscussion();
            TechnicalInterview();
            HRInterview();
        }

        protected abstract void FirstRoundTest();

        private void GroupDiscussion()
        {
            Console.WriteLine($"Conduct Group Discussion.{Environment.NewLine}");
        }

        protected abstract void TechnicalInterview();

        private void HRInterview()
        {
            Console.WriteLine($"Conduct HR Interview.{Environment.NewLine}");
        }
    }
}
