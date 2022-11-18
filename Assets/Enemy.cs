using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public int damage = 10;

    private void Start()
    {
        Invoke("OnDestroyed", 5f);
    }

    public void Update()
    {
        transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Typer player = col.GetComponent<Typer>();
        player.TakeDamage(damage);
    }

    void OnDestroyed()
    {
        Destroy(gameObject);
    }
}
