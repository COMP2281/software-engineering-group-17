using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Manager : MonoBehaviour
{
    public GameObject door_to_remove;
    public GameObject prev_audio;
    public GameObject next_audio;
    public GameObject temp_add;
    public GameObject perma_add;
    // Start is called before the first frame update
   public int key_num;
   public bool adds_sound = false;
   private bool opened = false;
   public float wait_time;

   void Update()
    {
        if (!opened && key_num == 0){

            if (adds_sound) {
                StartCoroutine(StartMusic());
            }

            else {
                door_to_remove.SetActive(false);
                prev_audio.SetActive(false);
                next_audio.SetActive(true);
            }

            opened = true;
        }
    } 

    IEnumerator StartMusic() {
        temp_add.SetActive(true);
        prev_audio.SetActive(false);
        next_audio.SetActive(true);
        yield return new WaitForSeconds(wait_time);
        temp_add.SetActive(false);
        door_to_remove.SetActive(false);
        perma_add.SetActive(true);
    }

}
