using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tablero : MonoBehaviour
{

    public int[][] matrix = new int[17][];
    public int[][] playersPos = new int[17][];
    public int map;
    public GameObject[] floorTiles;
    public GameObject[] enemies;
    public float tamX;
    public float tamY;
    public int posEnemyX;
    public int posEnemyY;
    public GameObject player;

    // Use this for initialization
    void Start()
    {
        //Inicializamos la matriz del tablero
        for (int i = 0; i < 17; i++)
        {
            matrix[i] = new int[18];
            playersPos[i] = new int[18];
            for (int j = 0; j < 18; j++)
            {
                matrix[i][j] = 0;
                playersPos[i][j] = 0;
            }
        }
        playersPos[16][13] = 1;
        if(map == 1)
        {
            GameObject obj = Instantiate(player, new Vector2((15 * tamX) + (12 * tamX) + 0.07f, (13 * tamY) - (16 * tamY)), Quaternion.identity);
            obj.GetComponent<Position>().x = 16;
            obj.GetComponent<Position>().y = 13;
        }
        else
        {
            GameObject obj = Instantiate(player, new Vector2(3*tamX + 0.07f, 3*tamY), Quaternion.identity);
            obj.GetComponent<Position>().x = 1;
            obj.GetComponent<Position>().y = 2;

        }

        creaMapa(matrix, map);
    }


    void creaMapa(int[][] matrix, int level)
    {
        int matrixFila = matrix.Length, matrixColumna = matrix[0].Length;

        if(level == 1)
        {
            //Creo la matriz directamente con la forma del PAIS VASCO
            matrix[0][0] = 0; matrix[0][1] = 2; matrix[0][2] = 2; matrix[0][3] = 2; matrix[0][4] = 2; matrix[0][5] = 2; matrix[0][6] = 2; matrix[0][7] = 2; matrix[0][8] = 2; matrix[0][9] = 2; matrix[0][10] = 2; matrix[0][11] = 2; matrix[0][12] = 2; matrix[0][13] = 2; matrix[0][14] = 2; matrix[0][15] = 2; matrix[0][16] = 2; matrix[0][17] = 2;
            matrix[1][0] = 0; matrix[1][1] = 2; matrix[1][2] = 2; matrix[1][3] = 2; matrix[1][4] = 2; matrix[1][5] = 2; matrix[1][6] = 2; matrix[1][7] = 2; matrix[1][8] = 2; matrix[1][9] = 2; matrix[1][10] = 2; matrix[1][11] = 2; matrix[1][12] = 2; matrix[1][13] = 2; matrix[1][14] = 2; matrix[1][15] = 2; matrix[1][16] = 2; matrix[1][17] = 2;
            matrix[2][0] = 1; matrix[2][1] = 1; matrix[2][2] = 1; matrix[2][3] = 1; matrix[2][4] = 1; matrix[2][5] = 1; matrix[2][6] = 2; matrix[2][7] = 2; matrix[2][8] = 2; matrix[2][9] = 2; matrix[2][10] = 1; matrix[2][11] = 1; matrix[2][12] = 1; matrix[2][13] = 1; matrix[2][14] = 1; matrix[2][15] = 1; matrix[2][16] = 1; matrix[2][17] = 1;
            matrix[3][0] = 1; matrix[3][1] = 1; matrix[3][2] = 1; matrix[3][3] = 1; matrix[3][4] = 1; matrix[3][5] = 1; matrix[3][6] = 1; matrix[3][7] = 1; matrix[3][8] = 1; matrix[3][9] = 1; matrix[3][10] = 1; matrix[3][11] = 1; matrix[3][12] = 1; matrix[3][13] = 1; matrix[3][14] = 1; matrix[3][15] = 1; matrix[3][16] = 1; matrix[3][17] = 1;
            matrix[4][0] = 1; matrix[4][1] = 1; matrix[4][2] = 1; matrix[4][3] = 1; matrix[4][4] = 1; matrix[4][5] = 1; matrix[4][6] = 1; matrix[4][7] = 1; matrix[4][8] = 1; matrix[4][9] = 1; matrix[4][10] = 1; matrix[4][11] = 1; matrix[4][12] = 1; matrix[4][13] = 1; matrix[4][14] = 1; matrix[4][15] = 1; matrix[4][16] = 1; matrix[4][17] = 0;
            matrix[5][0] = 0; matrix[5][1] = 0; matrix[5][2] = 0; matrix[5][3] = 0; matrix[5][4] = 1; matrix[5][5] = 1; matrix[5][6] = 1; matrix[5][7] = 1; matrix[5][8] = 1; matrix[5][9] = 1; matrix[5][10] = 1; matrix[5][11] = 1; matrix[5][12] = 1; matrix[5][13] = 1; matrix[5][14] = 1; matrix[5][15] = 1; matrix[5][16] = 1; matrix[5][17] = 0;
            matrix[6][0] = 0; matrix[6][1] = 0; matrix[6][2] = 0; matrix[6][3] = 0; matrix[6][4] = 1; matrix[6][5] = 1; matrix[6][6] = 1; matrix[6][7] = 1; matrix[6][8] = 1; matrix[6][9] = 1; matrix[6][10] = 1; matrix[6][11] = 1; matrix[6][12] = 1; matrix[6][13] = 1; matrix[6][14] = 1; matrix[6][15] = 1; matrix[6][16] = 1; matrix[6][17] = 0;
            matrix[7][0] = 0; matrix[7][1] = 0; matrix[7][2] = 0; matrix[7][3] = 0; matrix[7][4] = 1; matrix[7][5] = 1; matrix[7][6] = 1; matrix[7][7] = 1; matrix[7][8] = 1; matrix[7][9] = 1; matrix[7][10] = 1; matrix[7][11] = 1; matrix[7][12] = 1; matrix[7][13] = 1; matrix[7][14] = 1; matrix[7][15] = 1; matrix[7][16] = 1; matrix[7][17] = 0;
            matrix[8][0] = 0; matrix[8][1] = 0; matrix[8][2] = 1; matrix[8][3] = 1; matrix[8][4] = 1; matrix[8][5] = 1; matrix[8][6] = 1; matrix[8][7] = 4; matrix[8][8] = 4; matrix[8][9] = 1; matrix[8][10] = 1; matrix[8][11] = 1; matrix[8][12] = 1; matrix[8][13] = 1; matrix[8][14] = 1; matrix[8][15] = 1; matrix[8][16] = 0; matrix[8][17] = 0;
            matrix[9][0] = 0; matrix[9][1] = 0; matrix[9][2] = 1; matrix[9][3] = 1; matrix[9][4] = 1; matrix[9][5] = 1; matrix[9][6] = 1; matrix[9][7] = 4; matrix[9][8] = 4; matrix[9][9] = 1; matrix[9][10] = 1; matrix[9][11] = 1; matrix[9][12] = 1; matrix[9][13] = 1; matrix[9][14] = 1; matrix[9][15] = 1; matrix[9][16] = 0; matrix[9][17] = 0;
            matrix[10][0] = 0; matrix[10][1] = 0; matrix[10][2] = 4; matrix[10][3] = 4; matrix[10][4] = 4; matrix[10][5] = 4; matrix[10][6] = 4; matrix[10][7] = 4; matrix[10][8] = 4; matrix[10][9] = 4; matrix[10][10] = 4; matrix[10][11] = 1; matrix[10][12] = 1; matrix[10][13] = 1; matrix[10][14] = 1; matrix[10][15] = 1; matrix[10][16] = 0; matrix[10][17] = 0;
            matrix[11][0] = 0; matrix[11][1] = 0; matrix[11][2] = 0; matrix[11][3] = 0; matrix[11][4] = 4; matrix[11][5] = 4; matrix[11][6] = 4; matrix[11][7] = 3; matrix[11][8] = 3; matrix[11][9] = 3; matrix[11][10] = 4; matrix[11][11] = 4; matrix[11][12] = 1; matrix[11][13] = 1; matrix[11][14] = 1; matrix[11][15] = 0; matrix[11][16] = 0; matrix[11][17] = 0;
            matrix[12][0] = 0; matrix[12][1] = 0; matrix[12][2] = 0; matrix[12][3] = 0; matrix[12][4] = 0; matrix[12][5] = 4; matrix[12][6] = 4; matrix[12][7] = 3; matrix[12][8] = 3; matrix[12][9] = 3; matrix[12][10] = 3; matrix[12][11] = 4; matrix[12][12] = 4; matrix[12][13] = 4; matrix[12][14] = 4; matrix[12][15] = 0; matrix[12][16] = 0; matrix[12][17] = 0;
            matrix[13][0] = 0; matrix[13][1] = 0; matrix[13][2] = 0; matrix[13][3] = 0; matrix[13][4] = 0; matrix[13][5] = 0; matrix[13][6] = 4; matrix[13][7] = 4; matrix[13][8] = 3; matrix[13][9] = 3; matrix[13][10] = 3; matrix[13][11] = 3; matrix[13][12] = 3; matrix[13][13] = 4; matrix[13][14] = 4; matrix[13][15] = 0; matrix[13][16] = 0; matrix[13][17] = 0;
            matrix[14][0] = 0; matrix[14][1] = 0; matrix[14][2] = 0; matrix[14][3] = 0; matrix[14][4] = 0; matrix[14][5] = 0; matrix[14][6] = 0; matrix[14][7] = 4; matrix[14][8] = 4; matrix[14][9] = 3; matrix[14][10] = 3; matrix[14][11] = 3; matrix[14][12] = 3; matrix[14][13] = 3; matrix[14][14] = 3; matrix[14][15] = 0; matrix[14][16] = 0; matrix[14][17] = 0;
            matrix[15][0] = 0; matrix[15][1] = 0; matrix[15][2] = 0; matrix[15][3] = 0; matrix[15][4] = 0; matrix[15][5] = 0; matrix[15][6] = 0; matrix[15][7] = 0; matrix[15][8] = 4; matrix[15][9] = 4; matrix[15][10] = 3; matrix[15][11] = 3; matrix[15][12] = 3; matrix[15][13] = 3; matrix[15][14] = 3; matrix[15][15] = 0; matrix[15][16] = 0; matrix[15][17] = 0;
            matrix[16][0] = 0; matrix[16][1] = 0; matrix[16][2] = 0; matrix[16][3] = 0; matrix[16][4] = 0; matrix[16][5] = 0; matrix[16][6] = 0; matrix[16][7] = 0; matrix[16][8] = 0; matrix[16][9] = 4; matrix[16][10] = 4; matrix[16][11] = 4; matrix[16][12] = 4; matrix[16][13] = 4; matrix[16][14] = 4; matrix[16][15] = 0; matrix[16][16] = 0; matrix[16][17] = 0;
        }
        else
        {
            //Creo la matriz directamente con la forma de CATALUNYA
            matrix[0][0] = 0; matrix[0][1] = 0; matrix[0][2] = 3; matrix[0][3] = 3; matrix[0][4] = 3; matrix[0][5] = 3; matrix[0][6] = 3; matrix[0][7] = 3; matrix[0][8] = 0; matrix[0][9] = 0; matrix[0][10] = 0; matrix[0][11] = 0; matrix[0][12] = 0; matrix[0][13] = 0; matrix[0][14] = 0; matrix[0][15] = 0; matrix[0][16] = 0; matrix[0][17] = 0;
            matrix[1][0] = 0; matrix[1][1] = 0; matrix[1][2] = 3; matrix[1][3] = 3; matrix[1][4] = 3; matrix[1][5] = 3; matrix[1][6] = 3; matrix[1][7] = 3; matrix[1][8] = 1; matrix[1][9] = 1; matrix[1][10] = 1; matrix[1][11] = 1; matrix[1][12] = 1; matrix[1][13] = 1; matrix[1][14] = 1; matrix[1][15] = 1; matrix[1][16] = 2; matrix[1][17] = 2;
            matrix[2][0] = 0; matrix[2][1] = 0; matrix[2][2] = 3; matrix[2][3] = 3; matrix[2][4] = 3; matrix[2][5] = 3; matrix[2][6] = 3; matrix[2][7] = 3; matrix[2][8] = 3; matrix[2][9] = 4; matrix[2][10] = 4; matrix[2][11] = 1; matrix[2][12] = 1; matrix[2][13] = 1; matrix[2][14] = 1; matrix[2][15] = 1; matrix[2][16] = 2; matrix[2][17] = 0;
            matrix[3][0] = 0; matrix[3][1] = 0; matrix[3][2] = 0; matrix[3][3] = 1; matrix[3][4] = 1; matrix[3][5] = 1; matrix[3][6] = 3; matrix[3][7] = 3; matrix[3][8] = 4; matrix[3][9] = 1; matrix[3][10] = 1; matrix[3][11] = 1; matrix[3][12] = 1; matrix[3][13] = 1; matrix[3][14] = 1; matrix[3][15] = 1; matrix[3][16] = 2; matrix[3][17] = 0;
            matrix[4][0] = 0; matrix[4][1] = 0; matrix[4][2] = 0; matrix[4][3] = 1; matrix[4][4] = 1; matrix[4][5] = 3; matrix[4][6] = 3; matrix[4][7] = 4; matrix[4][8] = 1; matrix[4][9] = 1; matrix[4][10] = 1; matrix[4][11] = 2; matrix[4][12] = 2; matrix[4][13] = 2; matrix[4][14] = 2; matrix[4][15] = 2; matrix[4][16] = 0; matrix[4][17] = 0;
            matrix[5][0] = 0; matrix[5][1] = 0; matrix[5][2] = 0; matrix[5][3] = 1; matrix[5][4] = 1; matrix[5][5] = 3; matrix[5][6] = 4; matrix[5][7] = 1; matrix[5][8] = 1; matrix[5][9] = 1; matrix[5][10] = 1; matrix[5][11] = 2; matrix[5][12] = 2; matrix[5][13] = 0; matrix[5][14] = 0; matrix[5][15] = 0; matrix[5][16] = 0; matrix[5][17] = 0;
            matrix[6][0] = 0; matrix[6][1] = 0; matrix[6][2] = 0; matrix[6][3] = 1; matrix[6][4] = 4; matrix[6][5] = 4; matrix[6][6] = 1; matrix[6][7] = 1; matrix[6][8] = 1; matrix[6][9] = 2; matrix[6][10] = 2; matrix[6][11] = 2; matrix[6][12] = 2; matrix[6][13] = 0; matrix[6][14] = 0; matrix[6][15] = 0; matrix[6][16] = 0; matrix[6][17] = 0;
            matrix[7][0] = 0; matrix[7][1] = 0; matrix[7][2] = 0; matrix[7][3] = 1; matrix[7][4] = 4; matrix[7][5] = 1; matrix[7][6] = 1; matrix[7][7] = 1; matrix[7][8] = 1; matrix[7][9] = 2; matrix[7][10] = 2; matrix[7][11] = 0; matrix[7][12] = 0; matrix[7][13] = 0; matrix[7][14] = 0; matrix[7][15] = 0; matrix[7][16] = 0; matrix[7][17] = 0;
            matrix[8][0] = 1; matrix[8][1] = 1; matrix[8][2] = 1; matrix[8][3] = 4; matrix[8][4] = 4; matrix[8][5] = 1; matrix[8][6] = 2; matrix[8][7] = 2; matrix[8][8] = 2; matrix[8][9] = 2; matrix[8][10] = 2; matrix[8][11] = 0; matrix[8][12] = 0; matrix[8][13] = 0; matrix[8][14] = 0; matrix[8][15] = 0; matrix[8][16] = 0; matrix[8][17] = 0;
            matrix[9][0] = 0; matrix[9][1] = 1; matrix[9][2] = 3; matrix[9][3] = 1; matrix[9][4] = 2; matrix[9][5] = 2; matrix[9][6] = 2; matrix[9][7] = 2; matrix[9][8] = 2; matrix[9][9] = 2; matrix[9][10] = 2; matrix[9][11] = 0; matrix[9][12] = 0; matrix[9][13] = 0; matrix[9][14] = 0; matrix[9][15] = 0; matrix[9][16] = 0; matrix[9][17] = 0;
            matrix[10][0] = 0; matrix[10][1] = 4; matrix[10][2] = 1; matrix[10][3] = 1; matrix[10][4] = 2; matrix[10][5] = 2; matrix[10][6] = 2; matrix[10][7] = 0; matrix[10][8] = 0; matrix[10][9] = 0; matrix[10][10] = 0; matrix[10][11] = 0; matrix[10][12] = 0; matrix[10][13] = 0; matrix[10][14] = 0; matrix[10][15] = 0; matrix[10][16] = 0; matrix[10][17] = 0;
            matrix[11][0] = 0; matrix[11][1] = 4; matrix[11][2] = 1; matrix[11][3] = 2; matrix[11][4] = 2; matrix[11][5] = 0; matrix[11][6] = 0; matrix[11][7] = 0; matrix[11][8] = 0; matrix[11][9] = 0; matrix[11][10] = 0; matrix[11][11] = 0; matrix[11][12] = 0; matrix[11][13] = 0; matrix[11][14] = 0; matrix[11][15] = 0; matrix[11][16] = 0; matrix[11][17] = 0;
            matrix[12][0] = 1; matrix[12][1] = 4; matrix[12][2] = 1; matrix[12][3] = 2; matrix[12][4] = 0; matrix[12][5] = 0; matrix[12][6] = 0; matrix[12][7] = 0; matrix[12][8] = 0; matrix[12][9] = 0; matrix[12][10] = 0; matrix[12][11] = 0; matrix[12][12] = 0; matrix[12][13] = 0; matrix[12][14] = 0; matrix[12][15] = 0; matrix[12][16] = 0; matrix[12][17] = 0;
            matrix[13][0] = 1; matrix[13][1] = 4; matrix[13][2] = 1; matrix[13][3] = 2; matrix[13][4] = 0; matrix[13][5] = 0; matrix[13][6] = 0; matrix[13][7] = 0; matrix[13][8] = 0; matrix[13][9] = 0; matrix[13][10] = 0; matrix[13][11] = 0; matrix[13][12] = 0; matrix[13][13] = 0; matrix[13][14] = 0; matrix[13][15] = 0; matrix[13][16] = 0; matrix[13][17] = 0;
            matrix[14][0] = 1; matrix[14][1] = 4; matrix[14][2] = 1; matrix[14][3] = 2; matrix[14][4] = 0; matrix[14][5] = 0; matrix[14][6] = 0; matrix[14][7] = 0; matrix[14][8] = 0; matrix[14][9] = 0; matrix[14][10] = 0; matrix[14][11] = 0; matrix[14][12] = 0; matrix[14][13] = 0; matrix[14][14] = 0; matrix[14][15] = 0; matrix[14][16] = 0; matrix[14][17] = 0;
            matrix[15][0] = 1; matrix[15][1] = 4; matrix[15][2] = 1; matrix[15][3] = 2; matrix[15][4] = 0; matrix[15][5] = 0; matrix[15][6] = 0; matrix[15][7] = 0; matrix[15][8] = 0; matrix[15][9] = 0; matrix[15][10] = 0; matrix[15][11] = 0; matrix[15][12] = 0; matrix[15][13] = 0; matrix[15][14] = 0; matrix[15][15] = 0; matrix[15][16] = 0; matrix[15][17] = 0;
            matrix[16][0] = 1; matrix[16][1] = 4; matrix[16][2] = 1; matrix[16][3] = 2; matrix[16][4] = 0; matrix[16][5] = 0; matrix[16][6] = 0; matrix[16][7] = 0; matrix[16][8] = 0; matrix[16][9] = 0; matrix[16][10] = 0; matrix[16][11] = 0; matrix[16][12] = 0; matrix[16][13] = 0; matrix[16][14] = 0; matrix[16][15] = 0; matrix[16][16] = 0; matrix[16][17] = 0;

        }


        for (int i = 0; i < matrixFila; i++)
        {
            for (int j = 0; j < matrixColumna; j++)
            {

                GameObject tileHierba = floorTiles[Random.Range(0, 2)];
                GameObject tilePiedra = floorTiles[2];
                GameObject tileArena = floorTiles[3];
                GameObject tileMusgo = floorTiles[4];

                if (matrix[i][j] == 1) //dibujo hierba con flores
                    Instantiate(tileHierba, new Vector2((i * tamX) + (j * tamX), (j * tamY) - (i * tamY)), Quaternion.identity);
                else if (matrix[i][j] == 2) //dibujo arena
                    Instantiate(tileArena, new Vector2((i * tamX) + (j * tamX), (j * tamY) - (i * tamY)), Quaternion.identity);
                else if (matrix[i][j] == 3) //dibujo piedras
                    Instantiate(tilePiedra, new Vector2((i * tamX) + (j * tamX), (j * tamY) - (i * tamY)), Quaternion.identity);
                else if (matrix[i][j] == 4) //dibujo musgo
                    Instantiate(tileMusgo, new Vector2((i * tamX) + (j * tamX), (j * tamY) - (i * tamY)), Quaternion.identity);

                posEnemyX = i;
                posEnemyY = j;
                if (i == 5 && j == 5)
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
            obj.GetComponent<Position>().x = posEnemyX;
            obj.GetComponent<Position>().y = posEnemyY;



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
