using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager;

    public float wordDelay = 1.5f;
    public float nextWordTime = 0f;

    private void Update()
    {
        if (nextWordTime > 0)
        {
            nextWordTime -= Time.deltaTime;
        }
        else
        {
            wordManager.AddWord();
            nextWordTime = wordDelay;
            wordDelay -= 0.002f;
        }
    }

    public void DecreaseTime(float amount)
    {
        wordDelay -= amount;
        if (wordDelay <= .5f)
        {
            wordDelay = .5f;
        }
    }
}
