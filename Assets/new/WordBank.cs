using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class WordBank : MonoBehaviour
{
    private List<string> originalWords = new List<string>()
    {
        "evil", "eyes", "cold", "tree", "hide", "mars", "hidden", "hope", "dark", "black", "front",
        "life", "yours", "like", "jump", "favorite", "obnoxious", "fantastic", "spectacular", "admit", "along", "album",
        "money",
        "cable", "help", "lurking", "build", "built", "continuous", "past", "present", "future", "presenting", "gift",
        "grieve", "field", "globe", "earth", "sheep", "ship", "wolf", "logic", "flawless", "uranus", "neptune",
        "jupiter", "mercurius", "venus", "saturn", "beta", "gamma", "antares", "betelgeuse", "alnilam", "matter",
        "heart", "liver", "brain", "neuron", "scar", "moon", "star", "golden", "standard", "academy", "institute",
        "university", "country", "land", "oxygen", "steel", "nitrogen", "titanium", "aluminium", "silicon", "chlorine",
        "manganese", "iron", "steel", "uranium", "hydrogen", "helium", "calcium", "bone", "thermodynamics", "law",
        "pendulum", "wave", "magnet", "gravity", "force", "calculus", "inverse",
        "femur", "humour", "vertebrate", "mammal", "invertebrate", "virus", "bacteria", "amoeba"
    };

    private List<string> workingWords = new List<string>();

    private void Awake()
    {
        workingWords.AddRange(originalWords);
        Shuffle(workingWords);
        convertToLower(workingWords);
    }

    private void Shuffle(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int random = Random.Range(i, list.Count);
            string temporary = list[i];

            list[i] = list[random];
            list[random] = temporary;
        }
    }

    private void convertToLower(List<string> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            list[i] = list[i].ToLower();
        }
    }

    public string GetWord()
    {
        string newWord = string.Empty;

        if (workingWords.Count != 0)
        {
            newWord = workingWords.Last();
            workingWords.Remove(newWord);
        }
        
        return newWord;
    }
}
