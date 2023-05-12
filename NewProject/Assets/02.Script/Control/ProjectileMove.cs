using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    public enum BULLETTYPE
    {
        PLAEYR,
        ENMEY,
    }

    public BULLETTYPE bulletType = BULLETTYPE.PLAEYR;

    private void FixedUpdate()
    {
        float moveAmount = 3 * Time.fixedDeltaTime;
        transform.Translate(launchDirection * moveAmount);

        
    }

    private void OnCollisionEnter(Collision collision)
    {

             //�浹�� �Ͼ�� �̸��� �����´�
        if(collision.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�


        }

        if (collision.gameObject.tag == "Monster")      
        {
            collision.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�
        }

    }

    private void OnTriggerEnter(Collider other)
    {
            //�浹�� �Ͼ�� �̸��� �����´�
        if (other.gameObject.tag == "Wall")
        {
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�


        }

        if (other.gameObject.tag == "Monster" && bulletType == BULLETTYPE.PLAEYR)
        {
            other.gameObject.GetComponent<MonsterController>().Monster_Damaged(1);
            other.gameObject.transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f),
                    0.1f, 10, 1);
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�
        }

        if (other.gameObject.tag == "Player" && bulletType == BULLETTYPE.ENMEY)
        {
            other.gameObject.GetComponent<PlayerController>().Player_Damaged(1);
            GameObject temp = this.gameObject;        //�� �ڽ��� �����ͼ� temp�� �Է��Ѵ�
            Destroy(temp);                            // ��ٷ� �ı��Ѵ�
        }

    }
}
