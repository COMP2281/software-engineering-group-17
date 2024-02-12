using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_Manager : MonoBehaviour
{
    public GameObject door_to_remove;
    // Start is called before the first frame update
   public int key_num;

   void Update()
    {
        if (key_num == 0){
            door_to_remove.SetActive(false);
        }
    } 
}
