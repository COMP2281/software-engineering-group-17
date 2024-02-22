using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Shield : MonoBehaviour
{
    // Start is called before the first frame update
    public bool canShield;
    public bool isShielding = false;
    private GameObject player;
    public GameObject shieldBarObject;
    private SpriteRenderer sprite;
    private Collider2D shieldCollider;
    public float rate_decrease;
    private UnityEngine.UI.Slider shieldBar;

    void Start() {
        player = GameObject.FindGameObjectWithTag("Player");
        Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());

        shieldBar = shieldBarObject.GetComponent<UnityEngine.UI.Slider>();
        shieldCollider = gameObject.GetComponent<Collider2D>();
        sprite = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (canShield && Input.GetButton("Fire3")) {
            isShielding = true;
            sprite.enabled = true;
            shieldCollider.enabled = true;
        }

        else {
            isShielding = false; 
            sprite.enabled = false;
            shieldCollider.enabled = false;
        }

        gameObject.transform.position = player.transform.position;
    }

    void FixedUpdate() {
        if (isShielding) {
            shieldBar.value-= rate_decrease;
        }

        if (shieldBar.value <= 0) {
            canShield = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (isShielding && other.gameObject.tag.Equals("Bullet")) {
            Destroy(other.gameObject);
        }
    }
}
