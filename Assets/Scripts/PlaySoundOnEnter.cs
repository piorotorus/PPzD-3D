using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnEnter : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
          audioSource.PlayOneShot(audioClip);
        }
    }
}
