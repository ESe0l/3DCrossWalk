using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        //every frame get vertical & horizontal
        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
    
        Vector2 direction = new Vector2(horizontal, vertical); //reset
        direction = direction.normalized; //normalized?

        GetComponent<Rigidbody>().velocity = direction * speed;
    }
}
