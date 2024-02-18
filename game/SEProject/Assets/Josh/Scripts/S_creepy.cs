using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_creepy : MonoBehaviour
{
    public Text t;
    // Start is called before the first frame update
    void Start()
    {
        t.text = System.Environment.UserName;
    }

}
