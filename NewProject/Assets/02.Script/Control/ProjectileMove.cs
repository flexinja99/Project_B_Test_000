using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);

        
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.name);     //�浹�� �Ͼ�� �̸��� �����´�
        if(collision.gameObject.name == "Wall")
        {
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�


        }

        if (collision.gameObject.name == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�
        }

    }
}
