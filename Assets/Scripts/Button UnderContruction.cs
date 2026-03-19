using UnityEngine;

public class ButtonUnderContruction : MonoBehaviour
{
    [SerializeField]
    private GameObject hiddenTxt;
    public void ButtonunderConstruct() {
        hiddenTxt.SetActive(true);
    }
}
