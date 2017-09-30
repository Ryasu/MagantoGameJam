using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{

    private int[][] matrix = new int[17][];
    public int map;
    public GameObject[] floorTiles;
    public GameObject[] enemies;
    public float tamX;
    public float tamY;

    // Use this for initialization
    void Start()
    {
        for (int i = 0; i < 17; i++)
        {
            matrix[i] = new int[18];
            for (int j = 0; j < 18; j++)
            {
                matrix[i][j] = 0;
            }
        }
        creaMapa();
    }


    void creaMapa()
    {
        int matrixFila = matrix.Length, matrixColumna = matrix[0].Length;

        for (int i = 0; i < matrixFila; i++)
        {
            for (int j = 0; j < matrixColumna; j++)
            {
                GameObject losetilla = floorTiles[0];

                Instantiate(losetilla, new Vector2((i * tamX)+(j*tamX), (j * tamY) -(i*tamY)), Quaternion.identity);

                if(i == 10 && j == 17)
                {
                    createEnemy((i * tamX) + (j * tamX), (j * tamY) - (i * tamY));
                }
            }
        }
    }


    void createEnemy(float x, float y)
    {
        if(map == 1)
        {
            GameObject enemy = enemies[0];
            GameObject obj = Instantiate(enemy, new Vector2(x, y), Quaternion.identity);


        }
    }

    void createBoss()
    {

    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
