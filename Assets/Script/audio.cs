using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    

    public AudioSource audioSource; // "Audio Source" bileşenini referans almak için bir değişken tanımlayın

    void Start()
    {
        // İlgili sesi çalmaya başla
        audioSource.Play();
    }
}

