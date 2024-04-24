using System.Collections;
using UnityEngine;

public class Turret : MonoBehaviour
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
    private float startAngle;

    private void Start()
    {
        startAngle = gameObject.transform.eulerAngles.z;
        StartCoroutine(FireBullets());
    }
 

    private IEnumerator FireBullets()
    {
        yield return new WaitForSeconds(initWait);
        while (isFiring)
        {
            for (int i = 0; i < shotsFired; i++){
                
                Fire(spawnPoint);

                if (shootTwice) {
                    Fire(spawnPoint2);
                }


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

        if (!startRotation && startAngle + 1 > gameObject.transform.eulerAngles.z  && gameObject.transform.eulerAngles.z > startAngle - 1){
            rotationSpeed *=-1;
            startRotation = true;
        }   
        
    }
    private void Fire(GameObject point)
    {
        GameObject bullet = Instantiate(bulletPrefab, point.transform.position, point.transform.rotation);
        bullet.GetComponent<Bullet>().x = x;
        bullet.GetComponent<Bullet>().y = y;
        bullet.GetComponent<Bullet>().speed = speed;
    }
    
}
