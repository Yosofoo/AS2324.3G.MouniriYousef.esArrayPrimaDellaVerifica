﻿namespace AS2324._3G.MouniriYousef.esArrayPrimaDellaVerifica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire la dimensione dell'array");
            int dim = Convert.ToInt32(Console.ReadLine());
            double[] pesi = new double[dim];
            int[] eta = new int[dim];
            CaricaVettori(ref pesi, ref eta);

        }
        static void CaricaVettori(ref double[] pesi,ref int[] eta)
        {
            Random rnd = new Random();
            for (int i = 0; i < eta.Length; i++)
            {
                pesi[i] = rnd.Next(50, 101);
                eta[i] = rnd.Next(18, 100);
            }
        }
        static void Statistiche(ref double[] pesi, ref double media,ref double min,ref double max)
        {
            min = pesi[0];
            max = pesi[0];
            double somma  = 0;
            for (int i = 0; i <  pesi.Length; i++) 
            { 
                somma += pesi[i];
                if (pesi[i] > max)
                {
                    max = pesi[i];
                }
                if (pesi[i] < min)
                {
                    min = pesi[i];
                }
            }
            media = somma / pesi.Length;
        }
        static void Ordina(ref double[] pesi, ref int[] eta)
        {
            int min;
            for (int i = 0;i < eta.Length - 1; i++)
            {
                for(int j = 0; j < eta.Length - i - 1; j++)
                {
                    if (eta[j] < pesi[j + 1])
                    {
                        min = eta[j];
                        eta[j] = eta[j + 1];
                        eta[j+1] = min;
                    }
                }
            }
        }
    }
}
