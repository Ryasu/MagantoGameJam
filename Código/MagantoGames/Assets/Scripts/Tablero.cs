using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour {

    private int[][] matrix = new int[17][];
    public int map;
    public GameObject[] floorTiles;
    public float tamX;
    public float tamY;

    // Use this for initialization
    void Start () {
        for(int i = 0; i < 17; i++)
        {
            matrix[i] = new int[18];
            for(int j= 0; j < 18; j++)
            {
                matrix[i][j] = 0;
            }
        }
        creaMapa();
	}
	

    void creaMapa()
    {
        int matrixFila = matrix.Length, matrixColumna = matrix[0].Length;

        for(int i = 0; i < matrixFila; i++)
        {
            for(int j = 0; j < matrixColumna; j++)
            {
                GameObject losetilla = floorTiles[Random.Range(0, floorTiles.Length)];

                Instantiate(losetilla, new Vector2(i*tamX, j*tamY), Quaternion.identity);
            }
        }
    }



	// Update is called once per frame
	void Update () {
		if(map == 1)
        {

        }
	}
}
