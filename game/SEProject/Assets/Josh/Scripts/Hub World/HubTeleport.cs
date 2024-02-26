using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HubTeleport : MonoBehaviour
{
    public string sceneName;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player")) 
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
