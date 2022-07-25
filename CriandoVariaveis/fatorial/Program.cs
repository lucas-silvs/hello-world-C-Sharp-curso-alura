class fatorial
{
    static void Main(String[] args)
    {
        Console.WriteLine("Digite um número para ser o valor do fatorial");
        int entrada = Int32.Parse(Console.ReadLine());
        int total = entrada;
        while (entrada != 1)
        {
            entrada -= 1;
            total = total * entrada;
        }
        
        Console.WriteLine("Valor da fatorial: " + total);

        Console.ReadLine();

    }
    
}
