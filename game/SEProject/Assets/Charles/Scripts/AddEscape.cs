using UnityEngine;

public class AddEscape : MonoBehaviour
{
    public bool escapeStart = false;
    private bool hasStarted = false;
    public GameObject collisionsRun;
    public GameObject noCollisionsRuns;
    public GameObject removeable;
    public GameObject objectsToAddParent;
    private GameObject[] objectsToAdd;
    public int objectsNum;
    // Start is called before the first frame update
    void Start()
    {
        objectsNum = objectsToAddParent.transform.childCount;
        objectsToAdd = new GameObject[objectsNum];

        for (int i = 0; i < objectsNum; i++) {
            objectsToAdd[i] = objectsToAddParent.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted) {
            return;
        }

        if (escapeStart) {
            StartEscape();
            hasStarted = true;
        }

    }

    void StartEscape() {
        collisionsRun.SetActive(true);
        noCollisionsRuns.SetActive(true);
        removeable.SetActive(false);

        for (int i = 0; i < objectsNum; i++) {
            objectsToAdd[i].SetActive(true);
        }
    }
}
