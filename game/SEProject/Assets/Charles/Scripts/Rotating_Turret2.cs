using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotating_Turret2 : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject spawnPoint;
    public GameObject spawnPoint2;
    public bool shootTwice = false;
    public Bullet bulletClass;
    public float fireRate = 2f;
    public bool isFiring = true;
    public float x;
    public float y;
    public float initWait;
    public float speed;
    public float rotationSpeed;
    private bool startRotation = true;
    public int shotsFired;
    public float reloadingTime;
    public float endPoint;
    private float startPoint;

    private void Start()
    {
        startPoint = gameObject.transform.eulerAngles.z;
        if (shootTwice) {
            StartCoroutine(FireBullets2());
        }

        else {
            StartCoroutine(FireBullets());
        }
    }
 

    private IEnumerator FireBullets()
    {
        yield return new WaitForSeconds(initWait);
        while (isFiring)
        {
            for (int i = 0; i < shotsFired; i++){
                FireBullet();
                yield return new WaitForSeconds(fireRate);
            }

            yield return new WaitForSeconds(reloadingTime);
        } 
    }

    private IEnumerator FireBullets2()
    {
        yield return new WaitForSeconds(initWait);
        while (isFiring)
        {
            for (int i = 0; i < shotsFired; i++){
                FireBullet2();
                yield return new WaitForSeconds(fireRate);
            }

            yield return new WaitForSeconds(reloadingTime);
        } 
    }

    void FixedUpdate()
    {
        gameObject.transform.Rotate(0, 0, rotationSpeed, Space.Self);

        if (startRotation && endPoint + 1 > gameObject.transform.eulerAngles.z  && gameObject.transform.eulerAngles.z > endPoint - 1){
            rotationSpeed *=-1;
            startRotation = false;
        }
         if (!startRotation && startPoint + 1 > gameObject.transform.eulerAngles.z  && gameObject.transform.eulerAngles.z > startPoint - 1){
            rotationSpeed *=-1;
            startRotation = true;
        }   
        
    }
    private void FireBullet()
    {
        // Instantiate and set up the bullet here
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        bullet.GetComponent<Bullet>().x = x;
        bullet.GetComponent<Bullet>().y = y;
        bullet.GetComponent<Bullet>().speed = speed;
    }
    private void FireBullet2()
    {
        // Instantiate and set up the bullet here
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        bullet.GetComponent<Bullet>().x = x;
        bullet.GetComponent<Bullet>().y = y;
        bullet.GetComponent<Bullet>().speed = speed;
        GameObject bullet2 = Instantiate(bulletPrefab, spawnPoint2.transform.position, spawnPoint2.transform.rotation);
        bullet2.GetComponent<Bullet>().x = x;
        bullet2.GetComponent<Bullet>().y = y;
        bullet2.GetComponent<Bullet>().speed = speed;
        // isSpawned = true;
    }
}
