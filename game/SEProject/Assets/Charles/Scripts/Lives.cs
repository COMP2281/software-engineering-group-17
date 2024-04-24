using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public int heartNum = 3;
    public int maxHearts = 5; 
    private bool invincible = false;
    public float invincibleTime = 3f;
    private SpriteRenderer sprite;
    private Animator anim;

    void Start() {
        sprite = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (heartNum <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void DamagePlayer() {
        if (!invincible) {
            heartNum-=1;
            invincible = true;
            StartCoroutine(Flicker());
            StartCoroutine(InvincibleTimer());
        }

    }

    IEnumerator Flicker() {
        while (invincible) {
            anim.enabled = false;
            sprite.enabled = false;
            yield return new WaitForSeconds(0.2f);
            sprite.enabled = true;
            anim.enabled = true;
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator InvincibleTimer() {
        yield return new WaitForSeconds(invincibleTime);
        invincible = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Heart")
        {
            if (heartNum < maxHearts) {
                heartNum += 1;
                Destroy(other.gameObject);
            }
        }
    }
}
