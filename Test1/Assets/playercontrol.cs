using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontrol : MonoBehaviour
{
    public int speed = 3;
    public int health = 10;

    public GameObject bullet;
    public float fireRate = 0.3F;
    private float nextFire = 0.0F;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
    }

    void ShootBullet()
    {
        if ( Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
    void ProcessInput()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -8.5)
                transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < 8.5)
                transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (transform.position.y < 0)
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.y > -4)
                transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            ShootBullet();
        }
    }
}