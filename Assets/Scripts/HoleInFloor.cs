using UnityEngine;

public class HoleInFloor : MonoBehaviour
{
    [SerializeField]
    private GameObject disappearingFloor;
    private bool puzzleComplete;
    [SerializeField]
    private GameObject puzzleCompleteGameObj1;
    [SerializeField]
    private GameObject puzzleCompleteGameObj2;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player") && puzzleComplete) {
            disappearingFloor.SetActive(false);
        }
    }
    private void Update() {
        puzzleComplete = puzzleCompleteGameObj1.GetComponent<TextShowScript>().puzzle2Complete;
        if (puzzleComplete == false) {
            puzzleComplete = puzzleCompleteGameObj2.GetComponent<TextShowScript>().puzzle2Complete;
        }
    }
}
