using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lives : MonoBehaviour
{
    public int heart_num = 3; 
    void Update()
    {
        if (heart_num <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        GameObject heart = GameObject.FindGameObjectWithTag("Heart"); //Or however you get your player object here
        if (other.gameObject == heart)
        {
            heart_num += 1;
            Debug.Log(heart_num);
            Destroy(other.gameObject);
        }
    }
}
