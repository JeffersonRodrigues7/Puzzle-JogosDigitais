using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.SceneManagement;

public class Contador : MonoBehaviour
{
    [SerializeField] private TMP_Text countdownText;
    [SerializeField] private float countdownTime = 60.0f;
    private float currentTime = 0.0f;
    private bool isCountingDown = false;
    private AudioSource failure;

    private void Start()
    {
        currentTime = countdownTime;
        failure = GetComponent<AudioSource>();
        UpdateCountdownText();
    }

    private void Update()
    {
        if (isCountingDown)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                GameObject.Find("PontuacaoValue").GetComponent<Pontuacao>().canCount = false;
                currentTime = 0;
                isCountingDown = false;
                GameObject.Find("music").GetComponent<AudioPuzzle>().stopAudio();
                failure.Play();
                StartCoroutine(callNextScene());
            }

            UpdateCountdownText();
        }
    }

    public void StartCountdown()
    {
        isCountingDown = true;
    }

    public void StopCountdown()
    {
        isCountingDown = false;
    }

    private void UpdateCountdownText()
    {
        countdownText.text = currentTime.ToString("F0");
    }

    IEnumerator callNextScene()
    {

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene("MenuPrincipal");
    }
}