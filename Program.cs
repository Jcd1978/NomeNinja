Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("--- Nome Ninja ---\n");
Console.ResetColor();

Console.Write("Digite seu nome: ");

Console.ForegroundColor = ConsoleColor.Magenta;
string nome = Console.ReadLine()!; //Aguarda o usuário digitar algo e apertar Enter

//.Trim(): Remove espaços vazios acidentais no início ou fim do nome.

//.ToLower(): Converte tudo para letras minúsculas (para que o .Replace
//  encontre as letras corretamente).

string nomeNinja = nome.Trim().ToLower()
    .Replace("a", "KA")
    .Replace("b", "ZU")
    .Replace("c", "MI")
    .Replace("d", "TE")
    .Replace("e", "KU")
    .Replace("f", "LU")
    .Replace("g", "JI")
    .Replace("h", "RI")
    .Replace("i", "KI")
    .Replace("j", "ZUS")
    .Replace("k", "ME")
    .Replace("l", "TA")
    .Replace("m", "RIN")
    .Replace("n", "TO")
    .Replace("o", "MO")
    .Replace("p", "NO")
    .Replace("q", "KE")
    .Replace("r", "SHI")
    .Replace("s", "ARI")
    .Replace("t", "CHI")
    .Replace("u", "DO")
    .Replace("v", "RU")
    .Replace("w", "MEI")
    .Replace("x", "NA")
    .Replace("y", "FU")
    .Replace("z", "ZI");

//nomeNinja.Substring(0, 1).ToUpper():
//  Pega apenas a primeira letra do nome ninja gerado e a coloca em maiúscula.

//nomeNinja.Substring(1).ToLower():
//  Pega o restante do nome (da segunda letra em diante) e garante que esteja em minúsculo.

nomeNinja = $"{nomeNinja.Substring(0, 1).ToUpper()}{nomeNinja.Substring(1).ToLower()}";

//Exibe o resultado final formatado para o usuário.
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"\nSeu nome ninja é {nomeNinja}.\n");
Console.ResetColor();