using UnityEngine;

public class Goal2 : MonoBehaviour
{
    public bool wall2point1;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Interact") && this.gameObject.CompareTag("Goal2")) {
            wall2point1 = true;
        }
    }
}
