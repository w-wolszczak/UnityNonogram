using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Main game process
/// </summary>
public class Gamelvl1 : MonoBehaviour
{
    public static int DEFAULT_ROW = 5, DEFAULT_COLUMN = 5;

    public int row = DEFAULT_ROW, column = DEFAULT_COLUMN;

  

    public Grid grid;

    public float rate = 0.5f;

    public static int[,] puzzle00 = {
        { 1, 1, 0, 0, 0, 1 },
        { 0, 1, 0, 1, 1, 1 },
        { 0, 1, 0, 1, 1, 0 },
        { 0, 1, 1, 1, 0, 0 },
        { 0, 1, 1, 1, 1, 0 },
        { 0, 0, 0, 1, 0, 0 },};


    void Start()
    {
        if (PlayerPrefs.HasKey("Row"))
            row = PlayerPrefs.GetInt("Row");
        else row = DEFAULT_ROW;

        if (PlayerPrefs.HasKey("Column"))
            column = PlayerPrefs.GetInt("Column");
        else column = DEFAULT_COLUMN;

        int[,] puzzle = CreatePuzzle(row, column);

        //grid.LoadPuzzle(row,column,puzzle);
        grid.LoadPuzzle(6, 6, puzzle00);
        grid.playing = true;
    }

   
    public int[,] CreatePuzzle(int r, int c)
    {
    

        int[,] p = new int[c, r];

        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < r; j++)
            {
                float flag = Random.Range(0, 1f);
                if (flag < rate) p[i, j] = 1;
                else p[i, j] = 0;
            }
        }

        return p;
    }

}
