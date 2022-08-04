using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase);

        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        string cursos = "Cursos disponíveis: - Go - C# - Python - Java";
        Console.WriteLine(cursos);

        string cursos2 = "Cursos disponíveis: " +
           "- Go " +
           "- C# " +
           "- Python " +
           "- Java";
        Console.WriteLine(cursos2);

        string cursos3 = @"Cursos disponíveis: 
- Go
- C#
- Python
- Java";
        Console.WriteLine(cursos3);

        Console.WriteLine("Tecle enter para fechar ...");
        Console.ReadLine();
    }
}