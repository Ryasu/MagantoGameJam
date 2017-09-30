using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vida : MonoBehaviour
{

    private int vida;

    // Use this for initialization
    void Start()
    {

        vida = 10;

    }

    void perderVida()
    {
        vida = vida - 2;
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.F))
        {
            this.perderVida();
        }
    }
}
