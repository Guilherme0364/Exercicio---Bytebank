testaBuscarPalavra();

void testaBuscarPalavra()
{
    string[] arrayDePalavras = new string[5];

    for(int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digita a palavra da {i+1}ª posição: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser buscada: ");
    var busca = Console.ReadLine();

    foreach(string str in arrayDePalavras) { // Ele é responsavel por percorrer especificamente um array
        if (!str.Equals(busca))
        {
            break;
        }
        else
        {
            Console.Write($"A palavra {busca} foi encontrada.");
        }
    }
}