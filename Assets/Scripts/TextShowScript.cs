using UnityEngine;

public class TextShowScript : MonoBehaviour
{
    [SerializeField]
    private GameObject canvas;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Interact")) {
            canvas.SetActive(true);
        }
    }
}
