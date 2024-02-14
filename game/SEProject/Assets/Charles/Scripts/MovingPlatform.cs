using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

public class MvingPlatfor : MonoBehaviour
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
    private bool moving_down = false;
    public double range;

    void Start()
    {
        startPoint = start.transform.position;
        endPoint = end.transform.position;
        velocity = new UnityEngine.Vector3 (x*speed, y*speed, 0);
        // Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(),  GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += velocity;
        if (moving_down && UnityEngine.Vector3.Distance(gameObject.transform.position, startPoint) < range) {
            velocity *=-1;
            moving_down = false;
        }
        if (!moving_down && UnityEngine.Vector3.Distance(gameObject.transform.position, endPoint) < range) {
            velocity*= -1;
            moving_down = true;
        }
    }
}
