using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;


public class WordDisplay : MonoBehaviour
{
    public int damage = 10;
    public float timeToDecrease = 0.05f;
    public TMP_Text text;
    public float moveSpeed = 1f;

    public void SetWord(string word)
    {
        text.text = word;
    }

    public void RemoveLetter()
    {
        text.text = text.text.Remove(0, 1);
        text.color = Color.red;
    }

    public void RemoveWord()
    {
        Destroy(gameObject);
    }

    private void Update()
    {
        transform.Translate(-moveSpeed * Time.deltaTime, 0, 0f);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            PlayerController player = col.GetComponent<PlayerController>();
            player.TakeDamage(damage);
            
            
            Destroy(gameObject);
        }

        if (col.CompareTag("Wall"))
        {
            WordTimer timer = GameObject.FindObjectOfType<WordTimer>();
            timer.DecreaseTime(timeToDecrease);

            WordManager word = GameObject.FindObjectOfType<WordManager>();
            word.words.Remove(word.activeWord);
            word.activeWord = null;
            word.hasActiveWord = false;
            
            Destroy(gameObject);
        }
    }
}
