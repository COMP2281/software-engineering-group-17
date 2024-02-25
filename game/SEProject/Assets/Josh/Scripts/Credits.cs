using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject theEnd;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TheEnd());
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector2(this.transform.position.x, this.transform.position.y + 0.2f);
        
    }

    IEnumerator TheEnd()
    {
        yield return new WaitForSeconds(12);
        theEnd.SetActive(true);
        yield return new WaitForSeconds(10);
        Application.Quit();
    }

    
}
