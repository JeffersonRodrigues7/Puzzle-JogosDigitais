using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class chamaAbertura : MonoBehaviour
{
    public void AbrirGame(){
        SceneManager.LoadScene("Abertura");
    }

    public void ChamarCreditos()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                    Application.Quit(); // Isso encerra o aplicativo standalone.
        #endif
    }


}
