using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class chamaPuzzle : MonoBehaviour
{
    bool primeira;
    float t;
    void Start(){
        primeira = true;
        t = 0;
    }

    public void changeToPuzzle()
    {
        SceneManager.LoadScene("Puzzle1");
    }
}
