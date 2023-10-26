using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UniversalTracker : MonoBehaviour
{
    //TRACK VARIABLES
    private Vector3 _characterPosition;
    public Vector3 CharacterPosition{

        get => _characterPosition;

    }
    private int _doorOpenInteractionCount;
    public int DoorOpenInteractionCount{

        get => _doorOpenInteractionCount;

    }
    private int _playerStepCount;
    public int PlayerStepCount{

        get => _playerStepCount; 

    }
    //TRACK VARIABLES

    private static UniversalTracker _instance;

    public static UniversalTracker Instance{

        get => _instance;

    }

    private void Start() {
        
        if(_instance != null && _instance != this){

            Destroy(this);

        }

        _instance = this;

    }

    public void RecordPosition(Vector3 newPosition){ _characterPosition = newPosition; }
    public void IncreaseDoorOpenInteraction(){ _doorOpenInteractionCount++; }
    public void IncreasePlayerStepCount(){ _playerStepCount++; }

}
