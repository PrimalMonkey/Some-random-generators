using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Encription_
{
    class Methods
    {
        /*public static void genLCG(int size, int p, double[] arr)
        {
            // p = 13;
            double m = (Math.Pow(2, p) - 1);
            double b = m * 2;
            double a = b + 1;
            double c = 7;
            double X0 = 3;

            for (int i = 0; i < size; i++)
            {
                arr[i] = ((a * X0) + c) % m;
                X0 = arr[i];
            }
        }*/

        public static void genBBS(int size, int p, int q, double[] arr)
        {
            int m = p * q;
            int c = 7;
            double X0 = c * c;

            for (int i = 0; i < size; i++)
            {
                double temp = X0 % m;
                arr[i] = (X0 % m) % 2;
                X0 = temp * temp;
            }
        }
        
        public static string BBSToGraph(double[] input)
        {
            string temp = "";
            //double tempValue;
            for (int i = 0; i < input.Length; i++)
            {
                
                    temp += input[i];
                //temp += input[i];
            }

            return temp;
            /*for(int j = 0; j < 5; i++)
            {
                temp += input[j];
            }*/

            //output = Convert.ToDouble(temp);
        }



        public static void genLFSR(int size, double[] arr)
        {
            int a5 = 1;
            int a4 = 0;
            int a3 = 0;
            int a2 = 1;
            int a1 = 0;
            int a0 = 1;

            int[,] matrix = { { a4, a3, a2, a1, a0 }, { 1, 0, 0, 0, 0 }, { 0, 1, 0, 0, 0 }, { 0, 0, 1, 0, 0 }, { 0, 0, 0, 1, 0 } };
            int[] column = { a4, a3, a2, a1, a0 };
            int[] x0 = new int[5];
            matrixCalc(matrix, column, x0);

            for (int i = 0; i < size; i++)
            {
                int temp = to10(x0);
                arr[i] = temp;
                int[] xn = x0;
                x0 = new int[5];
                matrixCalc(matrix, xn, x0);
            }

        }

        public static void matrixCalc(int[,] matrix, int[] column, int[] result)
        {
            int[] temp = new int[5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                        temp[i] += (matrix[i, j] * column[j]);
                        result[i] = temp[i] % 2;
                }
            }
        }

        public static int to10(int[] arr)
        {
            string temp = "";
            int mod = 0;
            int s = 0;
            int count = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                temp += arr[i];
            }

            int num = Convert.ToInt32(temp);
            while (num > 0)
            {
                mod = num % 10;
                s = Convert.ToInt32(Math.Pow(2, count));
                result = result + mod * s;
                count++;
                num = num / 10;
            }

            return result;
        }

        public static int freq(double[] arr, int value)
        {
            int count = 0;
            Array.Sort(arr);
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] == value)
                {
                    count++;
                }
            }

            return count;
        }
    }
}

