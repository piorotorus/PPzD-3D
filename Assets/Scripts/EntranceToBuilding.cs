using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntranceToBuilding : MonoBehaviour
{
    [SerializeField] private AudioSource[] insideBuildingAudioList;
    [SerializeField] private AudioSource[] outsideBuildingAudioList;
    public bool isPlayerInBuilding;

    private void Awake()
    {
        MuteInsideAudio();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player")&&!isPlayerInBuilding)
        {
            Debug.Log("wbijam");
            isPlayerInBuilding = true;
            ActivateInsideAudio();
            MuteOutsideAudio();
        }
    }



   public void MuteInsideAudio()
    {
        foreach (var audioS in insideBuildingAudioList)
        {
            audioS.spatialBlend = 0;
            audioS.volume = 0.035f;
        }
    }

    void ActivateInsideAudio()
    {
        foreach (var audioS in insideBuildingAudioList)
        {
            audioS.spatialBlend = 1;
            audioS.volume = 0.15f;
        } 
    }
    
  public  void ActivateOutsideAudio()
    {
        foreach (var audioS in outsideBuildingAudioList)
        {
     
            audioS.volume = 0.5f;
        } 
    }
    
    public void MuteOutsideAudio()
    {
        foreach (var audioS in outsideBuildingAudioList)
        {
            audioS.spatialBlend = 0;
            audioS.volume = 0.035f;
        }
    }
    
}
