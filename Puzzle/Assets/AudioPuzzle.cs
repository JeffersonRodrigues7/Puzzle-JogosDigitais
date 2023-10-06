using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPuzzle : MonoBehaviour
{
    private AudioSource audioPuzzle;

    public void playPlay()
    {
        audioPuzzle = GetComponent<AudioSource>();
        audioPuzzle.Play();
    }

    public void stopAudio()
    {
        audioPuzzle.Stop();
    }
}
