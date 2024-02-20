using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    private GameObject snowGen;
    // Start is called before the first frame update
    void Start()
    {
        snowGen = this.transform.GetChild(0).gameObject;
    }

    // Update is called once per frame
    void Update()
    {
            snowGen.SetActive(GM.gmInstance.GetParticle());
    }
}
