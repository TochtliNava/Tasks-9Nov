using System;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_9Nov
{
    public class DiagonalMatrix
    {
        private int _size = 0;
        public DiagonalMatrix(int[] diagonal) 
        {
            if (diagonal != null)
            {
                _size = diagonal.Length;
            }
        }

        public int GetSize()
        {
            return _size;
        }

        

        public void CreateExtension(DiagonalMatrix matrix)
        {

        }
    }
}
