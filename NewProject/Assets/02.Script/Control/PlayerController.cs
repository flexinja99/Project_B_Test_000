using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10.0f;
    public GameObject PlayerPivot;
    Camera viewCamera;
    Vector3 velocity;
    public ProjectileController projectileController;
    public int Player_hp = 20;

    public void Player_Damaged(int damage)
    {
        Player_hp -= damage;

        if (Player_hp <= 0)
        {
            GameObject temp = this.gameObject;
            Destroy(temp);
        }


    }


    void Start()
    {
        viewCamera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = viewCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, viewCamera.transform.position.y));

        Vector3 targetPostion = new Vector3(mousePos.x, transform.position.y, mousePos.z);
        PlayerPivot.transform.LookAt(targetPostion, Vector3.up);
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")).normalized * moveSpeed;

        if (Input.GetMouseButtonDown(0))
        {
            projectileController.FireProjectile();
        }

    }

    void FixedUpdate()
    {
        GetComponent<Rigidbody>().MovePosition(GetComponent<Rigidbody>().position + velocity * Time.fixedDeltaTime);

    }
}
