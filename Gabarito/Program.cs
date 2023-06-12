Gabarito gabi = new Gabarito();

Prova p = new Prova(gabi);

Console.Write("Informe o nome do aluno: ");
string nome = Console.ReadLine();   

for(int i = 0; i < p.respostaAluno.Length; i++)//percorrer a quantidade de questões que o aluno vai
{
    Console.Write($"Informe a resposta da questão {i+1}: ");
    char resposta = Convert.ToChar(Console.ReadLine());
    p.RespostaAluno(char.ToUpper(resposta));
}

Console.WriteLine($"\nA quantidade de acertos é: {p.Acertos()}");
Console.WriteLine($"\nA nota é: {p.Nota()}");