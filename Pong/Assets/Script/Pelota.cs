using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    [SerializeField]
    Vector3 direction;
    [SerializeField]
    float speed = 6f;
    
    
    void Start()
    {
        direction = Vector3.right;
        direction.y = Random.Range(1f, -1f);
    }

    
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed; 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "jugador")
        {
            direction.x = direction.x * -1;
            direction.y = Random.Range(1f, -1f);
        }
        if(collision.gameObject.tag == "limits")
        {
            direction.y = direction.y* -1f;
        }
        Debug.Log("Ha chocado" + collision.collider.gameObject.name);
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        Debug.Log("Gol");
        transform.position = Vector3.zero;

        if (collision.gameObject.tag == "Porteria 1")
        {
            Debug.Log("GOL! del Jugador 2");
            Marcador.instance.GolJugador1();

        }
        if (collision.gameObject.tag == "Porteria 2")
        {
            Debug.Log("GOL! del Jugador 1");
            Marcador.instance.GolJugador2();

        }
    }

        
}
