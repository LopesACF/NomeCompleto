Console.Write("Qual o seu nome? ");
String nome = Console.ReadLine()!;
Console.Write("Qual seu sobrenome? ");
String sobrenome = Console.ReadLine()!;

String NomeSobrenome = $"{nome} {sobrenome}";

Console.WriteLine($"Olá, Boa noite {NomeSobrenome}");
