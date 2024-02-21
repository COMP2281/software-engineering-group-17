using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubBackground : MonoBehaviour
{
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -speed * Time.deltaTime);
    }
}
