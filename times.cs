 class Program
    {
        static void Main(string[] args)
        {
            string[] futebol = new string[5];
            int[] pontos = new int[5];
            int times = 0;
            for(int i = 0; i<5; i++)
            {
                Console.WriteLine("Digite o nome do time de futebol ");
                futebol[i] = Console.ReadLine();
                Console.WriteLine("Quantos pontos o {0} tem ", futebol[i]);
                pontos[i] = int.Parse(Console.ReadLine());
                times++;
                

            }
            for(int a = 0; a < times; a++)
            Console.Write("\n{0} \t\t {1} pontos", futebol[a], pontos[a]);

            Console.ReadKey();
      