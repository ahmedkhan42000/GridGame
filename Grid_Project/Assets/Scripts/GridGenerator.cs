using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridGenerator : MonoBehaviour
{
    public GameObject Cube;
    public int RowNumber, ColNumber;
    float GridH, GridW;

    public GameObject[,] Array2D;
    // Start is called before the first frame update
    void Start()
    {
        SpawnGrid();
    }

    void SpawnGrid()
    {
        Array2D = new GameObject[RowNumber, ColNumber];

        for (int i = 0; i < RowNumber; i++)
        {
            for (int j = 0; j < ColNumber; j++)
            {
                Array2D[i, j] = Instantiate(Cube, new Vector3(GridW, 0, GridH), transform.rotation);
                GridH += 2;

            }

            GridW += 2;
            GridH = 0;

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
