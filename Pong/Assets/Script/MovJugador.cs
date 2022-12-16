using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovJugador : MonoBehaviour
{
    [SerializeField]
    float speed = 10f;
    [SerializeField]
    KeyCode botonArriba;
    [SerializeField]
    KeyCode botonAbajo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(botonArriba))
        {
            transform.position += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(botonAbajo))
        {
            transform.position += Vector3.down * Time.deltaTime * speed;
        }
    }
}
