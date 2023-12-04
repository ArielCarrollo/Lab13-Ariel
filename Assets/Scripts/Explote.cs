using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explote : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource _compAudioSource;
    private Animator _compAnimator;
    void Awake()
    {
        _compAnimator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bola")
        {
            _compAnimator.SetBool("Explota?", true);
        }
    }
    private void Destroy()
    {
        Destroy(this.gameObject);
    }
    private void Bum()
    {
        _compAudioSource.Play();
    }
    // Update is called once per frame
}
