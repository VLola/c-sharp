using System;

namespace Project_29
{
    class Task_2
    {
        public void Start()
        {
            int N = 20, M = 20, a = 0;
            Random rnd = new Random();
            // Обьявляем массивы
            int[] A;
            int[] B;
            int[] C;
            // Выделяем память
            A = new int[N];
            B = new int[M];
            C = new int[0];
            for (int i = 0; i < A.Length; i++) A[i] = rnd.Next(100);
            for (int i = 0; i < B.Length; i++) B[i] = rnd.Next(100);
            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < B.Length; j++)
                {
                    int count = 0;
                    for (int k = 0; k < C.Length; k++)
                    {
                        if (A[i] == C[k]) count++;
                    }
                    if (A[i] == B[j] && count == 0)
                    {
                        Array.Resize(ref C, C.Length + 1);
                        C[a] = A[i];
                        a++;
                        break;
                    }
                }
            }

            for (int i = 0; i < A.Length; i++) Console.Write(A[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < B.Length; i++) Console.Write(B[i] + " ");
            Console.WriteLine();
            for (int i = 0; i < C.Length; i++) Console.Write(C[i] + " ");
            Console.WriteLine();
        }
    }
}
