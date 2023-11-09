using System;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9Nov._2
{
    internal class LectureLesson : PracticalLesson
    {
        private string _description { get; }

        public LectureLesson(string description)
        {
            _description = description;
        }
    }
}
