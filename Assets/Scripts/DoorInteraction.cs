using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour
{
    [SerializeField]private Animator _doorAnim;
    [SerializeField]private PlaySound _sound;
    private bool isDoorOpen = false;

    public void Interact(){

        if(!isDoorOpen)
            UniversalTracker.Instance.IncreaseDoorOpenInteraction();
      

        _doorAnim.SetBool("Close", isDoorOpen);
        _doorAnim.SetBool("Open", !isDoorOpen);

        _sound.Play();
        isDoorOpen = !isDoorOpen;

    }

    public void ResetAnimBools(){

        _doorAnim.SetBool("Close", false);
        _doorAnim.SetBool("Open", false);

    }
}
