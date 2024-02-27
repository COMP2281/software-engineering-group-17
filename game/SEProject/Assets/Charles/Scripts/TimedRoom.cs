using UnityEngine;

public class TimedRoom : MonoBehaviour
{
    private GameObject portal;
    public float rateDecrease;
    private bool timeBarOn = false;
    public UnityEngine.UI.Slider timeBar;
    public GameObject sliderParent;
    // Start is called before the first frame update
    void Start()
    {
        portal = transform.GetChild(0).gameObject;
        timeBar.value = 100;
        portal.SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timeBarOn) {
            timeBar.value -= rateDecrease;

            if (timeBar.value <= 0) {
                portal.SetActive(true);
                timeBar.value = 100;
                timeBarOn = false;
                sliderParent.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.tag == "Player") {
            timeBarOn = true;
            timeBar.enabled = true;
            sliderParent.SetActive(true);
        }
   }
}
