using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S_button : MonoBehaviour
{
    public S_player_movement player;
    private bool in_range;

    public bool correct_answer;

    public GameObject correct_answerbox;
    public GameObject wrong_answerbox;

    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && in_range)
        {
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
                player.canmove = false;
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
                StartCoroutine(Restart());
                player.canmove = false;
            }


        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            in_range = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            in_range = false;
        }
    }

    IEnumerator Restart()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator OpenDoor()
    {
        yield return new WaitForSeconds(2);
        correct_answerbox.SetActive(false);
        player.canmove = true;
    }
}
