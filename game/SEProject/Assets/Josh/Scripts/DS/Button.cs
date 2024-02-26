using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public PlayerScript player;
    private bool inRange;

    public bool correct_answer;

    public GameObject correct_answerbox;
    public GameObject wrong_answerbox;

    public GameObject wall;

    private AudioSource clip;
    // Start is called before the first frame update
    void Start()
    {
        clip = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && inRange)
        {
            clip.Play();
            if(correct_answer)
            {
                if (correct_answerbox.activeInHierarchy)
                {
                    correct_answerbox.SetActive(false);
                }
                else
                {
                    correct_answerbox.SetActive(true);
                }
                StartCoroutine(OpenDoor());
                player.canMove = false;
                wall.SetActive(false);
            }
            else {
                if (wrong_answerbox.activeInHierarchy)
                {
                    wrong_answerbox.SetActive(false);
                }
                else
                {
                    wrong_answerbox.SetActive(true);
                }
                StartCoroutine(Return());
                player.canMove = false;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            inRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            inRange = false;
        }
    }

    IEnumerator Return()
    {
        yield return new WaitForSeconds(2);
        wrong_answerbox.SetActive(false);
        player.canMove = true;
        Destroy(this.gameObject);
    }

    IEnumerator OpenDoor()
    {
        yield return new WaitForSeconds(2);
        correct_answerbox.SetActive(false);
        player.canMove = true;
        Destroy(this.gameObject);
    }
}
