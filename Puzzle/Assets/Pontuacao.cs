using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pontuacao : MonoBehaviour
{
    [SerializeField] private string nextScene = "Puzzle2";

    private int pontuacao = 0;
    private TMP_Text pontuacaoText;
    private AudioSource victory;
    public bool canCount = true;

    private void Start()
    {
        pontuacaoText = GetComponent<TMP_Text>();
        victory = GetComponent<AudioSource>();
    }

    public void addPontuation()
    {
        pontuacao++;
        pontuacaoText.text = pontuacao.ToString();

        if(pontuacao >= 25 && canCount)
        {
            GameObject.Find("TempoRestanteValue").GetComponent<Contador>().StopCountdown();
            GameObject.Find("music").GetComponent<AudioPuzzle>().stopAudio();
            victory.Play();
            StartCoroutine(callNextScene());
        }
    }

    IEnumerator callNextScene()
    {

        yield return new WaitForSeconds(5f);

        SceneManager.LoadScene(nextScene);
    }

}
