using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject[] hearts;
    public int maxHearts = 5;
    public int heartNum;
    public int newHeartNum;
    public GameObject player; 

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        hearts = new GameObject[maxHearts];

        for (int i = 0; i < maxHearts; i++) {
            hearts[i] = gameObject.transform.GetChild(i).gameObject;
        }    

        heartNum = player.GetComponent<Lives>().heartNum;
    }

    void Update()
    {
        newHeartNum = player.GetComponent<Lives>().heartNum;
        if (newHeartNum != heartNum) {
            ShowHearts();
            heartNum = newHeartNum;
        }
    }

    void ShowHearts() {
        for (int i = 0; i < newHeartNum; i++) {
            hearts[i].SetActive(true);
        }

        for (int i = newHeartNum; i < maxHearts; i++){
            hearts[i].SetActive(false);
        }
    }
}
