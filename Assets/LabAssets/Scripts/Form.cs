using UnityEngine;
using TMPro;

public class Form : MonoBehaviour
{
    private string Name;
    private string Surname;

    [SerializeField]
    private TMP_InputField nameInput;
    [SerializeField]
    private TMP_InputField surnameInput;

    [SerializeField]
    private TMP_Text outputText;

    public void Submit()
    {
        Name = nameInput.text;
        Surname = surnameInput.text;
    }

    public void CheckInfo()
    {
        outputText.text = $"Name: {Name}; Surname {Surname}";
    }
}
