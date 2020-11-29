using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickSoundManager : MonoBehaviour
{
 private AudioSource audioSource;
 [SerializeField] private AudioClip hitSound;
 [SerializeField] private AudioClip usePickSound;

 private void Start()
 {
  audioSource = GetComponent<AudioSource>();
 }

 public void PlayHitSound()
 {
  audioSource.PlayOneShot(hitSound);
 } 
 
 public void PlayUsePickSound()
   {
    audioSource.PlayOneShot(usePickSound);
   }
}
