using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HomingDrone : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private float x;
    private float y;
    public float speed;
    public float turnSpeed;
    private bool isEnding = false;
    private float dyingTime = 0.2f;
    public float timeAlive = 5f;
    public float startPhaseTime = 1;
    private bool homingPhase = false;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        x = transform.position.x;
        y = transform.position.y;
        StartCoroutine(DeathTimer());
        StartCoroutine(StartPhaseTimer());
    }

    IEnumerator StartPhaseTimer() {
        yield return new WaitForSeconds(startPhaseTime);
        homingPhase = true;
    }

    IEnumerator DeathTimer() {
        yield return new WaitForSeconds(timeAlive);
        gameObject.GetComponent<Animator>().enabled = true;
        StartCoroutine(EndDrone());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (homingPhase) {
            Vector3 myLocation = transform.position;
            Vector3 targetLocation = player.transform.position;
            targetLocation.z = myLocation.z; 
        
            Vector3 vectorToTarget = targetLocation - myLocation;
            Vector3 rotatedVectorToTarget = Quaternion.Euler(0, 0, 90) * vectorToTarget;
            
            Quaternion targetRotation = Quaternion.LookRotation(forward: Vector3.forward, upwards: rotatedVectorToTarget);
            
            // changed this from a lerp to a RotateTowards because you were supplying a "speed" not an interpolation value
            transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRotation, turnSpeed * Time.deltaTime);
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }

        else {
            transform.Translate(Vector3.right * speed*1.5f * Time.deltaTime, Space.Self);
        }

    }

    void Update() {
        if (!isEnding && Vector2.Distance(player.transform.position, transform.position) < 0.5) {
            player.GetComponent<Lives>().DamagePlayer();
            gameObject.GetComponent<Animator>().enabled = true;

            isEnding = true;
            StartCoroutine(EndDrone());
        }
    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Collide") {
            StartCoroutine(EndDrone());
        }
    }

    IEnumerator EndDrone() {
        yield return new WaitForSeconds(dyingTime);
        Destroy(gameObject);
    }
}
