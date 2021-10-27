namespace MatrixAndMessageDataWorker
{
    public abstract class AbstractMatrixSorter
    {
        public bool Ascending { get; set; }
        private bool _swapCondition = false;

        public AbstractMatrixSorter(bool ascending = true)
        {
            Ascending = ascending;
        }

        public abstract void SortMatrix(ref int[,] matrix);

        public bool SwapItems(ref int[] array, int leftI, int rightI)
        {
            if (rightI < array.Length)
            {
                _swapCondition = Ascending ?
                           IsMore(array[leftI], array[rightI]) : 
                           IsLess(array[leftI], array[rightI]);

                if (_swapCondition)
                {
                    var temp = array[leftI];
                    array[leftI] = array[rightI];
                    array[rightI] = temp;
                    return true;
                }
            }
            return false;
        }
        public bool IsMore(int left, int right) => (left > right);
        public bool IsLess(int left, int right) => (left < right);

        public void SwapMatrixRows(ref int[,] matrix, int leftRowI, int rightRowI)
        {
            var intSize = sizeof(int);

            var rowLength = matrix.GetLength(1);
            var rowDataLength = rowLength * intSize;
            var leftRowOffset = rowDataLength * leftRowI;
            var rightRowOffset = rowDataLength * rightRowI;

            // Temporary array for an intermediate step in the swap operation.
            var temp = new int[rowLength];

            // Copy left row into a temporary array.
            //                     (1 source, 2 srcOffset(bytes) 3 dst, 4 dstOffset(bytes), 5 count)
            System.Buffer.BlockCopy(matrix, leftRowOffset, temp, 0, rowDataLength);

            // Copy right row into the left row.
            System.Buffer.BlockCopy(matrix, rightRowOffset, matrix, leftRowOffset, rowDataLength);

            // Copy temporary array into the right row.
            System.Buffer.BlockCopy(temp, 0, matrix, rightRowOffset, rowDataLength);
        }
    }
}
