namespace AS2324._3G.MouniriYousef.esArrayPrimaDellaVerifica
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
            double media = 0;
            double min = 0; 
            double max = 0;
            int scelta;
            do
            {
                Console.WriteLine("1: Calcolo della media, del valore minimo e massimo tra i pesi");
                Console.WriteLine("2: Ordinamento dei pesi e età in ordine decrescente in base all'età");
                Console.WriteLine("0: fine del programma");
                Console.Write("Che operazione vuoi eseguire: ");
                scelta = Convert.ToInt32(Console.ReadLine());

                switch (scelta)
                {
                    case 1:
                        Statistiche(ref pesi, ref media, ref min, ref max);
                        Console.WriteLine($"La media dei pesi è {media}, il valore minimo è {min} e il valore massimo {max}");
                        break;
                    case 2:
                        Ordina(ref pesi, ref eta);
                        for (int i = 0; i < dim; i++)
                        {
                            Console.WriteLine($"età della persona {i + 1}: {eta[i]}");
                            Console.WriteLine($"peso della persona {i + 1}: {pesi[i]}\n");
                        }
                        break;
                }
            } while (scelta != 0);
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
            double tempPesi;
            int tempEta;
            for (int i = 0;i < eta.Length - 1; i++)
            {
                for(int j = 0; j < eta.Length - i - 1; j++)
                {
                    if (eta[j] < eta[j + 1])
                    {
                        tempEta = eta[j];
                        eta[j] = eta[j + 1];
                        eta[j+1] = tempEta;
                        tempPesi = pesi[j];
                        pesi[j] = pesi[j + 1];
                        pesi[j + 1] = tempPesi;
                    }
                }
            }
        }
    }
}
