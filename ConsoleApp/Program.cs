using System.Data;

//Problema 1:
//Implemente uma função em C# usando .NET Core que receba uma lista de palavras e retorne a palavra mais frequente, juntamente com a contagem de ocorrências. Considere que a lista de palavras não estará vazia e que sempre haverá uma palavra mais frequente.
//A função deve seguir as seguintes diretrizes:
//-Receber uma lista de palavras como parâmetro.
string GetMostFrequentWord(string[] words)
{
    //- Contar a frequência de cada palavra na lista.
    var wordDict = new Dictionary<string, int>();

    foreach (string word in words)
    {
        if(wordDict.ContainsKey(word))
        {
            wordDict[word]++;
        }

        else
        {
            wordDict.Add(word, 1);
        }
    }

    int maxOccurrences = wordDict.Values.Max();

    string mostFrequentWord = wordDict.FirstOrDefault(x => x.Value == maxOccurrences).Key;

    //- Retornar a palavra mais frequente e o número de ocorrências.

    //A palavra mais frequente é "uva", com 3 ocorrências.
    return "A palavra mais frequente é \"" + mostFrequentWord + "\", com " + maxOccurrences + " ocorrências.";
}

//Por exemplo, considere a lista de palavras: ["maçã", "banana", "uva", "banana", "uva", "uva"].
string[] listaDePalavras = { "maçã", "banana", "uva", "banana", "uva", "uva" };
string resultP1 = GetMostFrequentWord(listaDePalavras);

Console.WriteLine(resultP1);

//Problema 2:
//Implemente uma função em C# usando .NET Core que receba uma string contendo uma expressão matemática válida e retorne o resultado da avaliação dessa expressão.
//A função deve seguir as seguintes diretrizes:
//-Receber uma string contendo a expressão matemática.
int Calculate(string expression)
{
    var table = new DataTable();
    //- Avaliar a expressão e retornar o resultado.
    //Considere as seguintes considerações:
    //-A expressão matemática conterá apenas os seguintes caracteres: dígitos de 0 a 9, parênteses (), e os operadores matemáticos: +, -, *e /.
    //- A expressão não conterá espaços em branco.
    //- A ordem das operações deve ser respeitada (parênteses têm prioridade).
    //-A expressão será sempre válida, ou seja, não há necessidade de tratar erros de sintaxe.
    double resultP2 = (double)table.Compute(expression, "");

    int roundedResult = (int)Math.Round(resultP2);
    return roundedResult;
}

//Por exemplo, considere a string "2*(3+4)-5/2". A função deve retornar o resultado dessa expressão, que é 12.
string expression = "2*(3+4)-5/2";
int resultP2 = Calculate(expression);

Console.WriteLine(resultP2);
