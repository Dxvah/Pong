using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Marcador : MonoBehaviour
{
    public static Marcador instance;
    [SerializeField]
    TextMeshProUGUI resultadoJugador1, resultadoJugador2;

    int golesJugador1, golesJugador2;

    void Awake()
    {
        if(Marcador.instance == null)
        {
            Marcador.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    void Start()
    {
        golesJugador1 = 0;
        golesJugador2 = 0;
    }

    
    public void GolJugador1()
    {
        golesJugador1++;
        resultadoJugador1.text = golesJugador1.ToString();
    }
    public void GolJugador2()
    {
        golesJugador2++;
        resultadoJugador2.text = golesJugador2.ToString();
    }
}

