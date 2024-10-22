using System.Collections;
using UnityEngine;

public abstract class TurretStateMachine : MonoBehaviour
{
    public GameObject[] spawnPoints;
    public float beamStartup = 0.4f;
    public float[] rotationSpeeds;
    public GameObject[] prefabs;
    public float[] prefabAttributes;
    protected bool isFiring;
    public int straightFireNum;
    public float straightFireRate;
    public int[] nextState = new int [4] {1, 2, 3, 0};
    protected int spawnPointsNum;
    protected float startAngle;
    public bool startRotation;
    protected int direction = 1;
    public float endPoint;
    public enum States {
        ShootEnemies,
        ShootScattered,
        ShootStraight,
        ShootBeam
    }

    public States state;

    protected void SetStartAngle() {
        startAngle = gameObject.transform.eulerAngles.z;
    }

    protected void GetSpawnPoints() {
        spawnPointsNum = 0;
        int[] indicies = new int[transform.childCount];
        int j = 0;
        for (int i = 0; i < transform.childCount; i++) {
            if (transform.GetChild(i).name.Contains("Point")) {
                spawnPointsNum+=1;
                indicies[j] = i;
                j++;
            }
        }

        spawnPoints = new GameObject[spawnPointsNum];

        for (int i = 0; i < spawnPointsNum; i++) {
            spawnPoints[i] = transform.GetChild(indicies[i]).gameObject;
        }
   }
    public void MakeEnemy() {
        if (state != States.ShootEnemies) {
            return;
        }
        GameObject prefab = GetPrefab();
        for (int i = 0; i < spawnPointsNum; i++) {
            if (!spawnPoints[i].name.Contains("All") && !spawnPoints[i].name.Contains("Enemies")) {
                    continue;
                }

            GameObject enemy = Instantiate(prefab, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);

            enemy.GetComponent<HomingDrone>().speed = prefabAttributes[(int)state];
        }
    }

    public void ShootScatter() {
        GameObject prefab = GetPrefab();
        if (state != States.ShootScattered) {
            return;
        }
        for (int i = 0; i < spawnPointsNum; i++) {
            if (!spawnPoints[i].name.Contains("All") && !spawnPoints[i].name.Contains("Scattered")) {
                    continue;
                }

            GameObject bullet = Instantiate(prefab, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation);

            bullet.GetComponent<Bullet>().x = 0;
            bullet.GetComponent<Bullet>().y = -1;
            bullet.GetComponent<Bullet>().speed = prefabAttributes[(int)state];
        }
    }

    public IEnumerator ShootStraight() {
        GameObject prefab = GetPrefab();
        isFiring = true;
        for (int i  = 0; i < straightFireNum; i++) {
            for (int j = 0; j < spawnPointsNum; j++) {
                if (!spawnPoints[j].name.Contains("All") && !spawnPoints[j].name.Contains("Straight")) {
                    continue;
                }

                if (state != States.ShootStraight) {
                    yield break;
                }

                GameObject bullet = Instantiate(prefab, spawnPoints[j].transform.position, spawnPoints[j].transform.rotation);

                bullet.GetComponent<Bullet>().x = 0;
                bullet.GetComponent<Bullet>().y = -1;
                bullet.GetComponent<Bullet>().speed = prefabAttributes[(int)state];
            }

            yield return new WaitForSeconds(straightFireRate);
        }

        isFiring = false;
    }

    public void ShootBeam() {
        if (state != States.ShootBeam) {
            return;
        }
        GameObject prefab = GetPrefab();
        for (int i = 0; i < spawnPointsNum; i++) {
            if (spawnPoints[i].name.Contains("Beam")) {
                GameObject beam = Instantiate(prefab, spawnPoints[i].transform.position, spawnPoints[i].transform.rotation*Quaternion.Euler(0, 0, -90));
                beam.GetComponent<Beam>().deathTime = prefabAttributes[(int)state];
                beam.GetComponent<Beam>().startPhaseTime = beamStartup;
                beam.GetComponent<Beam>().spawnPoint = spawnPoints[i];
            }
        } 
    }
    public abstract float GetVelocity();

    protected void RotateTurret() {
        gameObject.transform.Rotate(0, 0, GetVelocity()*direction, Space.Self);

        if (startRotation && endPoint + 1 > gameObject.transform.eulerAngles.z  && gameObject.transform.eulerAngles.z > endPoint - 1){
            direction *=-1;
            startRotation = !startRotation;
        }
        else if (!startRotation && startAngle + 1 > gameObject.transform.eulerAngles.z  && gameObject.transform.eulerAngles.z > startAngle - 1){
            direction *=-1;
            startRotation = !startRotation;
        }
    }
    protected GameObject GetPrefab(){
        return prefabs[(int)state];
    }

}