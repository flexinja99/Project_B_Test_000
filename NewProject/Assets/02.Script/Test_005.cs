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
        
        for (int i =0; i< 10; i++) //0���� 9���� ¦�� ���
        {
            if(i%2 == 0)         //%�� ��������
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

        ///////////������/////////////////////////////////////////////////

        for (int i =0; i <10; i++)
        {
            for(int j =0; j<10; j++)
            {
                Debug.Log(i.ToString() + "x" + j.ToString() + " = " + (i * j).ToString()); // i x j = ���Ѱ�
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
