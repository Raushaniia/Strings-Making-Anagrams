using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        char[] stringA = a.ToCharArray();
        char[] stringB = b.ToCharArray();

        int result = 0;
        
        Dictionary<char, int> frequencyDictionary = new Dictionary<char, int>)
        {
            {'a',0},
            {'b',0},
            {'c',0},
            {'d',0},
            {'e',0},
            {'f',0},
            {'g',0},
            {'h',0},
            {'i',0},
            {'j',0},
            {'k',0},
            {'l',0},
            {'m',0},
            {'n',0},
            {'o',0},
            {'p',0},
            {'q',0},
            {'r',0},
            {'s',0},
            {'t',0},
            {'u',0},
            {'v',0},
            {'w',0},
            {'x',0},
            {'y',0},
            {'z',0}
        };

        for (int i = 0; i < string1.Length; i++)
        {
            char chr = stringA[i];
            frequencyDictionary[chr]++;
        }

        for (int i = 0; i < string2.Length; i++)
        {
            char chr = stringB[i];
            frequencyDictionary[chr]--;
        }

        foreach(var pair in frequencyDictionary)
        {
            result += Math.Abs(pair.Value);
        }
        
        Console.Write(result);
        
    }
}