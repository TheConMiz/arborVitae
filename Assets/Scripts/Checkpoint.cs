﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Defines checkpoint behaviour for individual checkpoints
public class Checkpoint : MonoBehaviour
{
    private LevelManager levelManager;

    private void Start()
    {
        levelManager = GameObject.FindGameObjectWithTag("LevelManager").GetComponent<LevelManager>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player1"))
        {
            Debug.Log(this.gameObject.name);
            levelManager.lastCheckpoint = transform.position;
        }
    }
}
