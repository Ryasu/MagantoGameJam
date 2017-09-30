using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchEnemy : MonoBehaviour {

    public int[][] range = new int[7][];
    private GameObject tablero;
    private int x;
    private int y;

	// Use this for initialization
	void Start () {
		for(int i= 0; i< 7; i++)
        {
            range[i] = new int[7];
            for(int j=0; j < 7; j++)
            {
                range[i][j] = 0;
                if(i == j || i == 0 || j == 0)
                {
                    range[i][j] = 1;
                }
            }
        }

        tablero = GameObject.FindWithTag("GameController");
        x = this.gameObject.GetComponent<Position>().x;
        y = this.gameObject.GetComponent<Position>().y;

    }

    // Update is called once per frame
    void Update()
    {
        for (int i = -3; i <= 3; i++)
        {
            for (int j = -3; i <= 3; i++)
            {
                if(i+x >= 0 && i+x < 17 && j + y >= 0 && j + y < 18 && tablero.GetComponent<Tablero>().matrix[i+x][j+y] == 20 && range[i][j] == 1)
                {
                    if(i == 0)
                    {
                        if(j < j + y)
                        {
                            for(int a= 1; a <= j; a++)
                            {
                                
                                this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + this.gameObject.GetComponent<Movement>().abajo.x, this.gameObject.transform.position.y + this.gameObject.GetComponent<Movement>().abajo.y);
                            }
                        }
                        else if(j > j + y)
                        {
                            for (int a = 1; a <= i; a++)
                            {
                                this.gameObject.transform.position = new Vector2(this.gameObject.transform.position.x + this.gameObject.GetComponent<Movement>().arriba.x, this.gameObject.transform.position.y + this.gameObject.GetComponent<Movement>().arriba.y);
                            }
                        }
                    }
                }
            }
        }
    }
}

