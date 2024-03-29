using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    public float roationSpeed = 1.0f;

    public GameObject bulletPrefab;
    public GameObject enemyPiovt;

    public Transform firePoint;
    public float fireRate = 1.0f;
    public float nextFireTime;

    private Rigidbody rb;
    private Transform player;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
            
    }

    private void Update()
    {
        if (player != null)
        if(Vector3.Distance(player.position, transform.position) > 1.0f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction * speed * Time.deltaTime);
        }
        Vector3 targetDirection = (player.position - enemyPiovt.transform.position).normalized;
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection);
        enemyPiovt.transform.rotation = Quaternion.Lerp(enemyPiovt.transform.rotation, targetRotation, roationSpeed * Time.deltaTime);

        if(Time.time > nextFireTime)
        {
            nextFireTime = Time.time + 1.0f / fireRate;
            GameObject temp = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            temp.GetComponent<ProjectileMove>().launchDirection = firePoint.localRotation * Vector3.forward;
            temp.GetComponent<ProjectileMove>().bulletType = ProjectileMove.BULLETTYPE.ENMEY;
        }
    }

    

}
