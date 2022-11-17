using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PlayerController : MonoBehaviour
{
    public int health = 100;
    public int curHealth;
    public Vector3[] pos;
    public float timeBetweenMove = 2f;
    public float timeMove;

    private void Start()
    {
        curHealth = health;
    }

    public void Update()
    {
        if (timeMove > 0)
        {
            timeMove -= Time.deltaTime;
        }
        else
        {
            timeMove = timeBetweenMove;
            int rand = Random.Range(0, pos.Length);
            Debug.Log(pos[rand]);

            transform.position = pos[rand];
        }
    }

    public void TakeDamage(int amount)
    {
        curHealth -= amount;
        if (curHealth <= 0)
        {
            curHealth = 0;
            //Game Over;
        }
    }
}
