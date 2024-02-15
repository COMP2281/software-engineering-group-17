using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public int heart_num = 3;
    public int max_hearts = 5; 
    void Update()
    {
        if (heart_num <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Heart")
        {
            if (heart_num < max_hearts) {
                heart_num += 1;
                Destroy(other.gameObject);
            }
        }
    }
}
