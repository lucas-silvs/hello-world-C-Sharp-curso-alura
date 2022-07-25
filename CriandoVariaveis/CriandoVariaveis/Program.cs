class Programa2
{
    static void Main(String[] arg)
    {
        int idade = 12;
        
        Console.WriteLine("Criando variaveis inteiras");
        Console.WriteLine(idade);
        
        Console.WriteLine("Criando variaveis double");
        Console.WriteLine("Digite uma idade: ");
        idade = Int32.Parse(Console.ReadLine());
        Console.WriteLine("digite um número decimal");
        double numeroDecimal = double.Parse(Console.ReadLine());
        Console.WriteLine(idade);
        Console.WriteLine(numeroDecimal);



    }
    
}
