using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_Turret2 : MonoBehaviour
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
    public float rotation_speed;
    public int shots_fired;
    public float reloading_time;
    public float rotation_range;
    private float init_rotation;
    private bool rotate_left;
    private float to_check;


    private void Start()
    {
        init_rotation = gameObject.transform.eulerAngles.z;
        rotate_left = rotation_range > 0;
        Debug.Log(init_rotation);
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
        gameObject.transform.Rotate(0, 0, rotation_speed, Space.Self);

        if (!rotate_left && gameObject.transform.eulerAngles.z > init_rotation+rotation_range+1) {
            to_check = gameObject.transform.eulerAngles.z - 360;
        }
        else if (rotate_left && gameObject.transform.eulerAngles.z < init_rotation-rotation_range-1) {
            to_check = gameObject.transform.eulerAngles.z + 360;
        }
        else {
            to_check = gameObject.transform.eulerAngles.z;
        }


        if (rotate_left && to_check > init_rotation+rotation_range) {
            rotation_speed*=-1;
            rotate_left = false;

            if (to_check < 0) {
                to_check+=360;
            }
            else if (to_check > 360) {
                to_check+=360;
            }
        }
        else if (!rotate_left && to_check < init_rotation-rotation_range) {
            rotation_speed*=-1;

            if (to_check < 0) {
                to_check+=360;
            }
            else if (to_check > 360) {
                to_check-=360;
            }

            rotate_left = true;
        }
    }
    private void FireBullet()
    {
        // Instantiate and set up the bullet here
        GameObject bullet = Instantiate(bullet_prefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        bullet.GetComponent<Bullet>().x = x;
        bullet.GetComponent<Bullet>().y = y;
        bullet.GetComponent<Bullet>().speed = speed;
        // isSpawned = true;
    }
}
