using System;

namespace Matriz1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] produtos = {
                                {"Nome","Preço"},
                                {"Calça","50"},
                                {"Blusa","25"},
                                {"meia","15"},
                                {"Bermuda","45"}
                            };
            for (int linha = 0; linha <= 4; linha++)
            {
                for (int coluna = 0; coluna <= 1; coluna++)
                {
                    Console.Write(produtos[linha, coluna] + "\t\t");
                }
                Console.WriteLine();
            }
        }
    }
}
