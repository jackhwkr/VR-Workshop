using UnityEngine;

public class ThrowGameObjInHole : MonoBehaviour
{
    [SerializeField]
    private GameObject wall;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Throw")) {
            wall.SetActive(false);
        }
    }
}
