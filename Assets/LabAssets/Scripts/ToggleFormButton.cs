using UnityEngine;

public class ToggleFormButton : MonoBehaviour
{
    [SerializeField]
    private GameObject Form;

    public void Toggle()
    {
        Form.SetActive(!Form.activeSelf);
    }
}
