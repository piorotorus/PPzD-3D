using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitBuilding : MonoBehaviour
{
    [SerializeField] private EntranceToBuilding entranceToBuilding;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("Player"))
        {
            Debug.Log("wychodze");
            entranceToBuilding.isPlayerInBuilding = false;
            entranceToBuilding.MuteInsideAudio();
            entranceToBuilding.ActivateOutsideAudio();
        } 
    }
}
