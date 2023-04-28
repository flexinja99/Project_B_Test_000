using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastController : MonoBehaviour
{

    public GameObject Monster;
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Ray cast = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;

            if(Physics.Raycast(cast, out hit)) // Rast �� �浹�� �����Ȱ͵� hit�� ������
            {
                if(hit.collider.tag == "Ground")
                {
                    GameObject temp = (GameObject)Instantiate(Monster);
                    temp.transform.position = hit.point + new Vector3(0.0f, 1.0f, 0.0f);
                }
               
                
                Debug.DrawLine(cast.origin, hit.point, Color.red, 2.0f);
            }
        }
    }
}
