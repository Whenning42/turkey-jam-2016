﻿using UnityEngine;
using System.Collections;



public class Zombie : MonoBehaviour
{

    public AudioSource zombie;

    // Use this for initialization
    void Awake()
    {
       zombie = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet")
        {  Destroy(gameObject);
           zombie.Play();
            
        }
    }
}
