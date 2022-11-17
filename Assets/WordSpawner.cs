using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{
    public GameObject wordPrefab;
    //public Transform wordCanvas;
    public Transform[] pos;

    public WordDisplay SpawnWord()
    {
        int rand = Random.Range(0, pos.Length);
        GameObject wordObj = Instantiate(wordPrefab, pos[rand].position, Quaternion.identity);
        WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
