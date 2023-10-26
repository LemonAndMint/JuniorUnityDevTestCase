using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIVariableConnector : MonoBehaviour
{
    [SerializeField] private TMP_Text _characterPositionText;
    [SerializeField] private TMP_Text _doorOpenedText;
    [SerializeField] private TMP_Text _playerMovedText;

    private void Update() {
        
        _characterPositionText.text = UniversalTracker.Instance.CharacterPosition.ToString();
        _doorOpenedText.text = UniversalTracker.Instance.DoorOpenInteractionCount.ToString();
        _playerMovedText.text = UniversalTracker.Instance.PlayerStepCount.ToString();

    }


}
