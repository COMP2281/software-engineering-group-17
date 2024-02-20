using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    private BoxCollider2D box;
    private SpriteRenderer spriteRenderer;

    public AlterCutscene4 cutscene;
    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        box.enabled = false;
        spriteRenderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(cutscene.cutsceneDone)
        {
            box.enabled = true;
            spriteRenderer.enabled = true;
        }
    }

}
