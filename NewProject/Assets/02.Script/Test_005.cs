using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_005 : MonoBehaviour
{
  
    void Start()
    {
        //for (int i = 0; i < 5; i++)
        //{
        //    Debug.Log(i);
        //}
        //for (int i =0; i <10; i += 2)
        //{
        //    Debug.Log(i);
        //}
        //for (int i =3; i>0; i--)
        //{
        //    Debug.Log(i);
        //}
        
        for (int i =0; i< 10; i++) //0부터 9까지 짝수 출력
        {
            if(i%2 == 0)         //%는 나머지값
            {
                Debug.Log(i);
            }
        }
         ////////////////////////////////////////////////////////////////
        int sum = 0;
        for(int i =0; i < 10; i++)
        {
            sum += i;
        }
        Debug.Log(sum);

        ///////////구구단/////////////////////////////////////////////////

        for (int i =0; i <10; i++)
        {
            for(int j =0; j<10; j++)
            {
                Debug.Log(i.ToString() + "x" + j.ToString() + " = " + (i * j).ToString()); // i x j = 곱한값
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
