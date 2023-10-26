using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;
    [SerializeField] private AudioClip _audioClip;
    [SerializeField] private float _volume=0.5f;
    public void Play()
    {

        _audioSource.PlayOneShot(_audioClip, _volume);
    
    }
}
