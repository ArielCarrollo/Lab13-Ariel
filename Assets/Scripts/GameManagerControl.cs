using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerControl : MonoBehaviour
{
    public AudioSource _compAudioSource;
    // Start is called before the first frame update
    void Awake()
    {
        _compAudioSource = GetComponent<AudioSource>();
    }
}
