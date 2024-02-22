using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BasicEnemyTurret : TurretStateMachine {
    public float[] stateTimers = new float[4] {1f, 1f, 1f, 1f};
    public float[] reloadingTimes = new float[4] {0.5f, 0.5f, 0.5f, 0.5f};

    public float rotationSpeed;
    public float acceleration;
    public float deceleration;
    public bool changeOnDirection;
    private bool isRotating;
    public float speedMax;
    private bool isAccelerating;
    public float speedMin;
    void Start() {
        SetStartPoint();
        GetSpawnPoints();
        nextState = new int [4] {1, 2, 3, 0};
        StartCoroutine(ShootHandler());
    }

    void FixedUpdate() {
        RotateTurret();
    }



    IEnumerator ShootHandler() {
        int index = (int)state;
        StartCoroutine(StartTimer(index));

        while ((int)state == index) {
            Fire();
            yield return new WaitForSeconds(reloadingTimes[index]);
        }

        if (changeOnDirection) {
            direction*=-1;
            startRotation = !startRotation;
        }
        rotationSpeed = rotationSpeeds[(int)state];
        isFiring = false;
        StartCoroutine(ShootHandler());
    }

    IEnumerator StartTimer(int index) {
        state = (States)index;
        yield return new WaitForSeconds(stateTimers[index]);
        state = (States)nextState[index];
    }

    public override float GetVelocity()
    {
        switch (state) {

            case States.ShootEnemies:
                return rotationSpeed;

            case States.ShootScattered:
                return rotationSpeed;

            case States.ShootStraight:
                if (Mathf.Abs(rotationSpeed) > speedMax) {
                    isAccelerating = false;
                }
                else if (Mathf.Abs(rotationSpeed) < speedMin) {
                    isAccelerating = true;
                }

                if (isAccelerating) {
                    rotationSpeed*=acceleration;
                }
                else {
                    rotationSpeed*= deceleration;
                }

                return rotationSpeed;

            case States.ShootBeam:
                return rotationSpeed;  
        }

        return 0f;
    }


    public void Fire()
    {
        switch (state) {
            case States.ShootEnemies:
                MakeEnemy();
                break;
            
            case States.ShootScattered:
                ShootScatter();
                break;
            
            case States.ShootStraight:
                if (!isFiring){
                    StartCoroutine(ShootStraight());
                }
                break;
            
            case States.ShootBeam:
                ShootBeam();
                break;
        }
    }

}