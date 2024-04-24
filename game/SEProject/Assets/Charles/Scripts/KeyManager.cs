using System.Collections;
using UnityEngine;

public class KeyManager : MonoBehaviour
{
    public GameObject doorToRemove;
    public GameObject prevAudio;
    public GameObject nextAudio;
    public GameObject tempAdd;
    public GameObject permaAdd;
    // Start is called before the first frame update
    public int keyNum;
    public bool addsSound = false;
    private bool opened = false;
    public float waitTime;
    private AudioSource audioSource;

    void Start() {
        audioSource = gameObject.GetComponent<AudioSource>();
    }


   void Update()
    {
        if (!opened && keyNum == 0){
            Debug.Log("Playing");
            audioSource.Play();
            if (addsSound) {
                StartCoroutine(StartMusic());
            }

            else {
                doorToRemove.SetActive(false);
            }

            opened = true;
        }
    } 

    IEnumerator StartMusic() {
        tempAdd.SetActive(true);
        prevAudio.SetActive(false);
        nextAudio.SetActive(true);
        yield return new WaitForSeconds(waitTime);
        tempAdd.SetActive(false);
        doorToRemove.SetActive(false);
        permaAdd.SetActive(true);
    }

}
