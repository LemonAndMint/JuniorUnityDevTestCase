using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerStarter : MonoBehaviour
{
    public UnityEvent startEvent;

    public void CallEvent(){

        if(startEvent != null)
            startEvent.Invoke();

    }

}
