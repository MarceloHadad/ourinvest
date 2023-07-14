using System.Data;

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
    return "A palavra mais frequente é \"" + mostFrequentWord + "\", com " + maxOccurrences + " ocorrências.";
}

//Por exemplo, considere a lista de palavras: ["maçã", "banana", "uva", "banana", "uva", "uva"].
string[] listaDePalavras = { "maçã", "banana", "uva", "banana", "uva", "uva" };
string resultP1 = GetMostFrequentWord(listaDePalavras);

Console.WriteLine(resultP1);

//-Receber uma string contendo a expressão matemática.
int Calculate(string expression)
{
    var table = new DataTable();
    //- Avaliar a expressão e retornar o resultado.
    double resultP2 = (double)table.Compute(expression, "");

    int roundedResult = (int)Math.Round(resultP2);
    return roundedResult;
}

//Por exemplo, considere a string "2*(3+4)-5/2". A função deve retornar o resultado dessa expressão, que é 12.
string expression = "2*(3+4)-5/2";
int resultP2 = Calculate(expression);

Console.WriteLine(resultP2);
