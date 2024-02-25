using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Beam : MonoBehaviour
{

    public float defDistance = 10f;
    public float deathTime = 1f;
    private bool damagePhase = false;
    private Color startColor = Color.red;
    private Color endColor = Color.red;
    public float startPhaseTime = 1f;
    private LineRenderer line;
    public GameObject spawnPoint;
    private GameObject player;

    void Start() {
        StartCoroutine(DeathTimer());
        StartCoroutine(ManagePhase());
        line = GetComponent<LineRenderer>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update() {
        Shoot();
        transform.position = spawnPoint.transform.position;
        transform.rotation = spawnPoint.transform.rotation*UnityEngine.Quaternion.Euler(0, 0, -90);
    }


    IEnumerator DeathTimer() {
        yield return new WaitForSeconds(deathTime);
        Destroy(gameObject);
    }

    void Shoot() {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right);

        if (hit) {
            if (damagePhase && hit.collider.gameObject == player) {
                player.GetComponent<Lives>().DamagePlayer();
            }

            DrawBeam(transform.position, hit.point);
        }
        else {
            DrawBeam(transform.position, transform.right*defDistance);
        }
    }

    void DrawBeam(UnityEngine.Vector2 startPos, UnityEngine.Vector2 endPos) {
        line.SetPosition(0, startPos);
        line.SetPosition(1, endPos);
    }

    IEnumerator ManagePhase() {
        yield return new WaitForSeconds(startPhaseTime);

        float alpha = 1.0f;
        Gradient gradient = new Gradient();
        gradient.SetKeys(
            new GradientColorKey[] { new GradientColorKey(startColor, 0.0f), new GradientColorKey(endColor, 1.0f) },
            new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
        );
        line.colorGradient = gradient;

        damagePhase = true;
    }

}