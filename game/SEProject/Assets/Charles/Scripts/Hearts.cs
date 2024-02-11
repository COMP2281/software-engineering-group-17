using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject[] hearts;
    public int max_hearts = 5;
    public int heart_num;
    public int new_heart_num;
    public GameObject player; //Or however you get your player object here
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        hearts = new GameObject[max_hearts];

        for (int i = 0; i < max_hearts; i++) {
            hearts[i] = gameObject.transform.GetChild(i).gameObject;
        }    

        heart_num = player.GetComponent<Lives>().heart_num;
    }

    // Update is called once per frame
    void Update()
    {
        new_heart_num = player.GetComponent<Lives>().heart_num;
        if (new_heart_num != heart_num) {
            ShowHearts();
            heart_num = new_heart_num;
        }
    }

    void ShowHearts() {
        Debug.Log(new_heart_num);
        for (int i = 0; i < new_heart_num; i++) {
            hearts[i].SetActive(true);
        }

        for (int i = new_heart_num; i < max_hearts; i++){
            hearts[i].SetActive(false);
        }
    }
}
