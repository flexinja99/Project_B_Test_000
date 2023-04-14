using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public Vector3 launchDirection;
    public GameObject Projectile;
   
  

    public void FireProjectile()
    {
        GameObject temp = (GameObject)Instantiate(Projectile); //발사체 프리맵을 생성시키고 temp에 입력
                                                               // Instantiate 함수는 GameObjecct,프리팹을 생성

        temp.transform.position = this.gameObject.transform.position;
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;
        Destroy(temp, 10f);
    }
  
}
