using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour {

    private int[][] matrix;
    public int map;
	// Use this for initialization
	void Start () {
        for(int i = 0; i< 17; i++)
        {
            for(int j= 0; j< 18; j++)
            {
                matrix[i][j] = 0;
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
