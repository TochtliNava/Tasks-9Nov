using System;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9Nov
{
    public class DiagonalMatrix
    {
        private int _size;
        public DiagonalMatrix(int[] diagonal) 
        {
            _size = diagonal.Length;
        }

        public int GetSize()
        {
            return _size;
        }
    }
}
