using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] public PlaySound walkSound;
    [SerializeField] private float _speed;
    public void Move(Vector3 dir){

        transform.position += dir * _speed * Time.deltaTime;
        if(walkSound)
            walkSound.Play();

        UniversalTracker.Instance.IncreasePlayerStepCount();

    }

    private void Update() {
        
        UniversalTracker.Instance.RecordPosition(transform.position);

    }

}
