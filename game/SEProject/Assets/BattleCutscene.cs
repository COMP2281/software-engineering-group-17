using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class BattleCutscene : MonoBehaviour
{
    public GameObject background;
    public GameObject player;
    public GameObject enemy;
    public GameObject text;

    public float fadeDuration = 2.0f; 

    public GameObject ptarget;
    public GameObject etarget;
    public GameObject ttarget;
    private void Start()
    {
        Image image1 = background.GetComponent<Image>();
        Image image2 = player.GetComponent<Image>();
        Image image3 = enemy.GetComponent<Image>();
        Image image4 = text.GetComponent<Image>();
        StartCoroutine(FadeOutRoutine(image1, image2, image3, image4, fadeDuration));
    }

    private IEnumerator FadeOutRoutine(Image image1, Image image2, Image image3, Image image4, float duration)
    {

        yield return new WaitForSeconds(7.5f);
        float counter = 0;

        Color imageColor1 = image1.color;
        Color imageColor2 = image2.color;
        Color imageColor3 = image3.color;
        Color imageColor4 = image4.color;

        while (counter < duration)
        {
            counter += Time.deltaTime;
            float alpha = Mathf.Lerp(1.0f, 0.0f, counter / duration);

            image1.color = new Color(imageColor1.r, imageColor1.g, imageColor1.b, alpha);
            image2.color = new Color(imageColor2.r, imageColor2.g, imageColor2.b, alpha);
            image3.color = new Color(imageColor3.r, imageColor3.g, imageColor3.b, alpha);
            image4.color = new Color(imageColor4.r, imageColor4.g, imageColor4.b, alpha);

            
            yield return null; 

        }
        Destroy(this.gameObject);
    }

    private void Update()
    {

            float step = Time.deltaTime; 
            player.transform.position = Vector3.Lerp(player.transform.position, ptarget.transform.position, step);
            enemy.transform.position = Vector3.Lerp(enemy.transform.position, etarget.transform.position, step);
            text.transform.position = Vector3.Lerp(text.transform.position, ttarget.transform.position, step);
        
    }

}
