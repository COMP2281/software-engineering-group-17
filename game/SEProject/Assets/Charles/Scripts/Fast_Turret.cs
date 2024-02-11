using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using JetBrains.Annotations;

public class Fast_Turret : MonoBehaviour
{
    public GameObject bullet_prefab;
    public GameObject spawnPoint;
    public Bullet bulletClass;
    public float fireRate = 2f;
    public bool isFiring = true;
    public float x;
    public float y;
    public float init_wait;
    public float speed;
    public int shots_fired;
    public float reloading_time;

    private void Start()
    {
        StartCoroutine(FireBullets());
    }
 

    private IEnumerator FireBullets()
    {
        yield return new WaitForSeconds(init_wait);
        while (isFiring)
        {
            for (int i = 0; i < shots_fired; i++){
                FireBullet();
                yield return new WaitForSeconds(fireRate);
            }

            yield return new WaitForSeconds(reloading_time);
        }
    }
    void Update()
    {
        // if (isSpawned){
        //     bullet.Rigidbody2D = rb
        //     rb.velocity = transform.up * y * speed + transform.right * x * speed;
        // }
    }
    private void FireBullet()
    {
        // Instantiate and set up the bullet here
        GameObject bullet = Instantiate(bullet_prefab, spawnPoint.transform.position, gameObject.transform.rotation);
        bullet.GetComponent<Bullet>().x = x;
        bullet.GetComponent<Bullet>().y = y;
        bullet.GetComponent<Bullet>().speed = speed;
        // isSpawned = true;
    }
}
