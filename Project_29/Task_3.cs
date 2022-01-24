using System;

namespace Project_29
{
    class Task_3
    {
        public void Start()
        {
            Random rnd = new Random();
            int[,] A = new int[5, 5];
            int _iMin = 0, _jMin = 0, _iMax = 0, _jMax = 0, min = A[0, 0], max = A[0, 0], Sum = 0;


            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    A[i, j] = rnd.Next(-100, 100);
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (min > A[i, j])
                    {
                        min = A[i, j];
                        _iMin = i;
                        _jMin = j;
                    }

                    if (max < A[i, j])
                    {
                        max = A[i, j];
                        _iMax = i;
                        _jMax = j;

                    }
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }

            if (_iMin > _iMax)
            {
                int iTemp = _iMin;
                int jTemp = _jMin;
                _iMin = _iMax;
                _jMin = _jMax;
                _iMax = iTemp;
                _jMax = jTemp;
            }
            else if (_iMin == _iMax)
            {
                if (_jMin > _jMax)
                {
                    int jTemp = _jMin;
                    _jMin = _jMax;
                    _jMax = jTemp;
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    if (i == _iMin && j > _jMin && i != _iMax) Sum += A[i, j];
                    else if (i == _iMax && j < _jMax && i != _iMin) Sum += A[i, j];
                    else if (i > _iMin && i < _iMax) Sum += A[i, j];
                    else if (i == _iMin && i == _iMax && (j > _jMin && j < _jMax)) Sum += A[i, j];
                }
            }
            Console.WriteLine("Минимальное значение " + Math.Min(min, max));
            Console.WriteLine("Максимальное значение " + Math.Max(min, max));
            Console.WriteLine("Подсчет элементов массива между координат [" + _iMin + ", " + _jMin + "] и [" + _iMax + ", " + _jMax + "]");
            Console.WriteLine("Сумма элементов массива " + Sum + ", расположенных между минимальным и максимальным элементами.");
        }
    }
}
