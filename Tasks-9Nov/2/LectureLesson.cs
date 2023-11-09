using System;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9Nov._2
{
    internal class LectureLesson : Lesson
    {
        private string _description { get; }

        public LectureLesson(string description)
        {
            _description = description;
        }
    }
}
