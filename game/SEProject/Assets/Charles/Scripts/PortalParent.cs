using System.Collections;
using UnityEngine;

public class PortalParent : MonoBehaviour
{
    public float cooldownTime;
    public bool onCooldown;
    public bool disableOnUse;
    private GameObject[] portals;
    private int portalNum;
    void Start() {
        portalNum = gameObject.transform.childCount;
        portals = new GameObject[portalNum];

        for (int i = 0; i < portalNum; i++) {
            portals[i] = gameObject.transform.GetChild(i).gameObject;
            portals[i].GetComponent<AIPortal>().index = i;
        }
    }    

    public GameObject GetNextPortal(int index) {
       StartCoroutine(StartCooldown());

        if (index + 1 == portalNum) {
            return portals[0];
        }

        return portals[index+1];
    }

    IEnumerator StartCooldown() {
        onCooldown = true;

        yield return new WaitForSeconds(cooldownTime);

        onCooldown = false;

        if (disableOnUse) {
            DisableAll();
        }
    }

    void DisableAll() {
        for (int i = 0; i < portalNum; i++) {
            portals[i].SetActive(false);
        }

        gameObject.SetActive(false);
    }
}
