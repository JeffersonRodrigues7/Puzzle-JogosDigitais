using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tocadorPlay : MonoBehaviour
{
    AudioSource audio2;

    public void playPlay(){
        audio2 = GetComponent<AudioSource>();
        Debug.Log("Tocando áudio play");
        audio2.Play();
    }
}
