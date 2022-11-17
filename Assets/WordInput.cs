using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour
{
    public WordManager wordManager;
    private void Update()
    {
        foreach (var letter in Input.inputString)
        {
            Debug.Log(letter);
            wordManager.TypeLetter(letter);
        }
    }
}
