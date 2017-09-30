using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour {

    private int damage;
    private int cont, cont2, pasos;
    private bool atacando, atacando2;
    public GameObject attack;
    private GameObject ataque;

	// Use this for initialization
	void Start () {

        damage = 3;
        cont = 0;
        atacando = false;
        atacando2 = false;
        cont2 = 0;
        pasos = 0;
	}

    void atacar(int skill)
    {
        if(skill == 1)//ataque basico
        {
            ataque = Instantiate(attack, new Vector2(this.transform.position.x - 0.3f, this.transform.position.y - 0.15f), Quaternion.identity);
        }
        else if(skill == 2)//ataque a ditancia
        {
            ataque = Instantiate(attack, new Vector2(this.transform.position.x - 0.3f, this.transform.position.y - 0.15f), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
        if (atacando)
            cont++;
        if (atacando2)
            cont2++;

        if (Input.GetKey(KeyCode.G))//ataque basico
        {
            if(!atacando && !atacando2)
            {
                atacando = true;
                this.atacar(1);
            } 
        }
        if (Input.GetKey(KeyCode.H))//ataque distancia
        {
            if (!atacando && !atacando2)
            {
                atacando2 = true;
                this.atacar(2);
            }
        }

        if(atacando2)
        {
            if(cont2 > 10)
            {
                ataque.transform.position = new Vector2(ataque.transform.position.x - 0.3f, ataque.transform.position.y - 0.15f);
                cont2 = 0;
                pasos++;
                if(pasos >= 5)
                {
                    Destroy(ataque);
                    atacando2 = false;
                    pasos = 0;
                }
            }
        }
        if(cont > 50)
        {
            Destroy(ataque);
            cont = 0;
            atacando = false;
        }
	}
}
