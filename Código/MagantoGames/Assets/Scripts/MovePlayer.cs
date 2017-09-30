using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public Vector2 izquierda;
    public Vector2 derecha;
    public Vector2 arriba;
    public Vector2 abajo;
    private GameObject tablero;
    // Use this for initialization

    public int cont = 0;



    void Start()
    {
        izquierda = new Vector2(-0.3f, 0.15f);
        derecha = new Vector2(0.3f, -0.15f);
        arriba = new Vector2(0.3f, 0.15f);
        abajo = new Vector2(-0.3f, -0.15f);
        tablero = GameObject.FindGameObjectWithTag("GameController");
    }

    private void Update()
    {

        int horizontal;
        int vertical;
        cont++;
        if (cont >= 30)
        {
            cont = 0;
            horizontal = (int)Input.GetAxisRaw("Horizontal");
            vertical = (int)Input.GetAxisRaw("Vertical");

            if(vertical == 1 && this.gameObject.GetComponent<Position>().y <18 && tablero.GetComponent<Tablero>().matrix[this.gameObject.GetComponent<Position>().x] [this.gameObject.GetComponent<Position>().y+1] != 0)//arriba
            {
                this.transform.position = new Vector2(this.transform.position.x + arriba.x, this.transform.position.y + arriba.y);
                this.gameObject.GetComponent<Position>().y++;
            }
            else if (horizontal == 1 && this.gameObject.GetComponent<Position>().x < 17 && tablero.GetComponent<Tablero>().matrix[this.gameObject.GetComponent<Position>().x+1][this.gameObject.GetComponent<Position>().y] != 0)//derecha
            {
                this.transform.position = new Vector2(this.transform.position.x + derecha.x, this.transform.position.y + derecha.y);
                this.gameObject.GetComponent<Position>().x++;
            }
            else if(vertical == -1 && this.gameObject.GetComponent<Position>().y > 0 && tablero.GetComponent<Tablero>().matrix[this.gameObject.GetComponent<Position>().x][this.gameObject.GetComponent<Position>().y-1] != 0)//abajo
            {
                this.transform.position = new Vector2(this.transform.position.x + abajo.x, this.transform.position.y + abajo.y);
                this.gameObject.GetComponent<Position>().y--;
            }
            else if (horizontal == -1 && this.gameObject.GetComponent<Position>().x > 0 && tablero.GetComponent<Tablero>().matrix[this.gameObject.GetComponent<Position>().x - 1][this.gameObject.GetComponent<Position>().y] != 0)//izquierda
            {
                this.transform.position = new Vector2(this.transform.position.x + izquierda.x, this.transform.position.y + izquierda.y);
                this.gameObject.GetComponent<Position>().x--;

            }
        }
    }
}
