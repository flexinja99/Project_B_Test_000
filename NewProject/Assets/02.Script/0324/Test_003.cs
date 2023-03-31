using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;
    void Start()
    {
        

        if(herbNum == 1)
        {
            Debug.Log("체력이 바닥났으");
        }
        else
        {
            Debug.Log("체력이 과연 찾을까");
        }
        
    }

    
    void Update()
    {
        
    }
}
