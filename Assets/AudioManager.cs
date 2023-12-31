using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header ("--- Audio Source ---")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--- Audio Clip ---")]
    public AudioClip background;
    public AudioClip checkpoint;
    public AudioClip cointouch;
    public AudioClip jump;

    private void Start()
    {
        musicSource.clip = background;
        musicSource.Play();

    }

}
