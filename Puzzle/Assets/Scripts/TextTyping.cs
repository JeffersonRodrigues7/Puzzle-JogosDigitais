using System.Collections;
using UnityEngine;
using TMPro;

public class TextTyping : MonoBehaviour
{
    [SerializeField] private float typingSpeed = 0.01f;

    private TMP_Text textField;
    private string originalText;
    private string currentText = "";
    private int currentCharIndex = 0;
    private float waitBeforePuzzle = 2f;

    private void Start()
    {
        textField = GetComponent<TMP_Text>();
        originalText = textField.text;
        textField.text = "";

        StartCoroutine(TypeText());
    }

    IEnumerator TypeText()
    {
        while (currentCharIndex < originalText.Length)
        {
            currentText += originalText[currentCharIndex];
            textField.text = currentText;

            currentCharIndex++;
            yield return new WaitForSeconds(typingSpeed);
        }

        yield return new WaitForSeconds(waitBeforePuzzle);

        GameObject.FindAnyObjectByType<chamaPuzzle>().changeToPuzzle();
    }
}
