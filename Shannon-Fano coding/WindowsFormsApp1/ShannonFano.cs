using System;
using System.Collections.Generic;
using System.Text;

namespace ShannonFanoProgram
{
    class ShannonFanoNode
    {
        public char Symbol { get; set; }
        public int Frequencie { get; set; }
        public string Code { get; set; }
    }

    static class ShannonFano
    {
        static private List<ShannonFanoNode> nodes;

        //Вычисляем частоту встречаемости каждого символа, сортируем символы по убыванию этой частоты, и создаём коды для каждого символа с помощью EncodeRecursive
        static public List<ShannonFanoNode> Encode(string inputText)
        {
            Dictionary<char, int> symbolsFrequencies = new Dictionary<char, int>();

            foreach (char symbol in inputText)
            {
                if (symbolsFrequencies.ContainsKey(symbol))
                {
                    symbolsFrequencies[symbol]++;
                }
                else
                {
                    symbolsFrequencies[symbol] = 1;
                }
            }

            List<KeyValuePair<char, int>> symbolFreqList = new List<KeyValuePair<char, int>>(symbolsFrequencies);

            for (int i = 1; i < symbolFreqList.Count; i++)
            {
                int j = i;
                while (j > 0 && symbolFreqList[j - 1].Value < symbolFreqList[j].Value)
                {
                    var temp = symbolFreqList[j - 1];
                    symbolFreqList[j - 1] = symbolFreqList[j];
                    symbolFreqList[j] = temp;
                    j--;
                }
            }

            nodes = new List<ShannonFanoNode>();

            foreach (var pair in symbolFreqList)
            {
                nodes.Add(new ShannonFanoNode { Symbol = pair.Key, Code = "", Frequencie = pair.Value });
            }

            EncodeRecursive(0, nodes.Count - 1, "");

            return nodes;
        }
        //Строим коды для символов по методу Шеннона-Фано
        static private void EncodeRecursive(int start, int end, string code)
        {
            if (start == end)
            {
                // Конечный узел
                nodes[start].Code = code;
            }

            else if (start < end)
            {
                // Делим узлы на две группы
                int sum = 0;

                for (int i = start; i <= end; i++)
                {
                    sum += nodes[i].Frequencie;
                }

                int halfSum = 0;
                int index = -1;

                for (int i = start; i <= end; i++)
                {
                    int newHalfSum = halfSum + nodes[i].Frequencie;
                        
                    if (Math.Abs(newHalfSum - sum / 2) <= Math.Abs(halfSum - sum / 2))
                    {
                        halfSum = newHalfSum;
                        index = i;
                    }
                    else
                    {
                        break;
                    }
                }

                // Рекурсивно вызываем метод для двух групп
                EncodeRecursive(start, index, code + "0");
                EncodeRecursive(index + 1, end, code + "1");
            }
        }
        //Кодирует текст, исходя из кодов каждого символа
        static public string FullyEncodeText(string originalText, List<ShannonFanoNode> nodes)
        {
            StringBuilder encodedText = new StringBuilder();

            foreach (char symbol in originalText)
            {
                string code = null;
                foreach (ShannonFanoNode node in nodes)
                {
                    if (node.Symbol == symbol)
                    {
                        code = node.Code;
                        break;
                    }
                }
                if (code != null)
                {
                    encodedText.Append(code);
                }
            }   

            return encodedText.ToString();
        }
        //Декодирует закодированный текст, исходя из кодов каждого символа
        static public string Decode(string encodedText, List<ShannonFanoNode> nodes)
        {
            StringBuilder decodedText = new StringBuilder();
            string currentCode = "";

            foreach (char bit in encodedText)
            {
                currentCode += bit;
                ShannonFanoNode matchingNode = null;
                foreach (ShannonFanoNode node in nodes)
                {
                    if (node.Code == currentCode)
                    {
                        matchingNode = node;
                        break;
                    }
                }
                if (matchingNode != null)
                {
                    decodedText.Append(matchingNode.Symbol);
                    currentCode = "";
                }
            }

            return decodedText.ToString();
        }
    }
}
