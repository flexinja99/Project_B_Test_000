using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmapleTileMap : MonoBehaviour
{
    public GameObject tile;
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            for(int j = 0; j<10; j++)
            {
                GameObject temp = (GameObject)Instantiate(tile);
                temp.transform.position = new Vector3(i, 0, j);
            }
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
