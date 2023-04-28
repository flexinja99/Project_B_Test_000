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

             //충돌이 일어날때 이름을 가져온다
        if(collision.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;        //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                            // 곧바로 파괴한다


        }

        if (collision.gameObject.tag == "Monster")
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;        //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                            // 곧바로 파괴한다
        }

    }

    private void OnTriggerEnter(Collider other)
    {
            //충돌이 일어날때 이름을 가져온다
        if (other.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;        //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                            // 곧바로 파괴한다


        }

        if (other.gameObject.tag == "Monster")
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;        //나 자신을 가져와서 temp에 입력한다
            Destroy(temp);                            // 곧바로 파괴한다
        }

    }
}
