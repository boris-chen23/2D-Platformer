﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public float speed;

    void Start()
    {

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage TAKEN");
        Destroy(gameObject);

    }
}