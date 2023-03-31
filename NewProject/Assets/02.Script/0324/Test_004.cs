using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test_004 : MonoBehaviour
{
    public int hp = 180;
    public Text textUI;
    public Text hpTextUI;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 왼
        {
            hp += 10;
        }
        if (Input.GetMouseButtonDown(1)) // 오
        {
            hp -= 10;
        }

        if (hp <= 50)
        {
           // Debug.Log("런");
            textUI.text = "런";
        }
        else if (hp >= 200)
        {
           // Debug.Log("응애");
            textUI.text = "응애";
        }
        else
        {
            //Debug.Log("멀바");
            textUI.text = "멀바";
        }

        hpTextUI.text = "HP :"+ hp.ToString(); //ToString 정수를 문자열로 바꿔주는 함수 ("HP: 숫자")
    }
}
