using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float x;
    public float y;
    public float speed;
    public GameObject start;
    public GameObject end;
    private UnityEngine.Vector3 startPoint;
    private UnityEngine.Vector3 endPoint;
    private UnityEngine.Vector3 velocity;
    public Rigidbody2D rb;
    private bool movingDown = false;
    public double range;

    void Start()
    {
        startPoint = start.transform.position;
        endPoint = end.transform.position;
        velocity = new UnityEngine.Vector3 (x*speed, y*speed, 0);
        // Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(),  GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        gameObject.transform.position += velocity;
        if (movingDown && UnityEngine.Vector3.Distance(gameObject.transform.position, startPoint) < range) {
            velocity *=-1;
            movingDown = false;
        }
        if (!movingDown && UnityEngine.Vector3.Distance(gameObject.transform.position, endPoint) < range) {
            velocity*= -1;
            movingDown = true;
        }
    }
}
