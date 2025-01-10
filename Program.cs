// Exercício 1: 
// uscaPalavra();
void buscaPalavra()
{
    string[] arrayDePalavras = new string[5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.Write($"Digita a palavra da {i + 1}ª posição: ");
        arrayDePalavras[i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser buscada: ");
    var busca = Console.ReadLine();

    foreach (string str in arrayDePalavras)
    { // Ele é responsavel por percorrer especificamente um array
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


// Exercício 2: 

Array amostra = Array.CreateInstance(typeof(int), 5);

amostra.SetValue(4, 0);
amostra.SetValue(1, 1);
amostra.SetValue(3, 2);
amostra.SetValue(7, 3);
amostra.SetValue(9, 4);

mediana(amostra);
void mediana(Array array)
{

    if ((array == null) || (array.Length == 0)){
        Console.Write("O array não pode ser nulo ou vazio.");
    }

    // Faz o cast para que o array seja int e não object (array recebido por parâmetro)
    int[] numerosOrdenados = (int[]) array.Clone();

    Array.Sort(numerosOrdenados); // Ordena o array passado como argumento

    int tamanho = numerosOrdenados.Length; // Tamanho do array
    int meio = tamanho / 2; // Metade do tamanho do array para pegarmos o valor da mediana

    // Se o resto da divisão de "tamanho" divido por 2 for diferente de 0 (ou seja, se for impar), retorna a posição imediatamente
    int mediana = (tamanho % 2 != 0) ? numerosOrdenados[meio] : (numerosOrdenados[meio] + numerosOrdenados[meio + 1] / 2);

    Console.Write($"Com base na amostra, a mediana é igual a: {mediana}");
}
