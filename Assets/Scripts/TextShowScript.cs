using UnityEngine;

public class TextShowScript : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
    private GameObject wallOpen;
    private GameObject wallOpen2;
    private bool wall2point1;
    private bool wall2point2;
    public bool puzzle2Complete;
    [SerializeField]
    private GameObject goal2ScriptObj;
    private void Start() {
        wallOpen = GameObject.Find("DisapearWall");
        wallOpen2 = GameObject.Find("DisapearWall (1)");
    }
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Interact") && this.gameObject.CompareTag("Goal1")) {
            canvas.SetActive(true);
            wallOpen.SetActive(false);
        }
        if (other.gameObject.CompareTag("Interact") && this.gameObject.CompareTag("Goal3")) {
            wall2point2 = true;
        }
    }
    private void OnCollisionExit(Collision other) {
        if (other.gameObject.CompareTag("Interact") && this.gameObject.CompareTag("Goal1")) {
            canvas.SetActive(false);
            wallOpen.SetActive(true);
        }
    }
    private void Update() {
        wall2point1 = goal2ScriptObj.GetComponent<Goal2>().wall2point1;
        if (wall2point1 && wall2point2) {
            wallOpen2.SetActive(false);
            puzzle2Complete = true;
        }
        
    }
}
