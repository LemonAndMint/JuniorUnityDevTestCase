using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIEventConnector : MonoBehaviour
{
    [Header("Buttons")]
    public Button UpButton;
    public Button DownButton;
    public Button LeftButton;
    public Button RightButton;

    [Space(5f)]

    [Header("Components")]
    public PlayerMovement playerMovement;

    private void Start() {

        if(playerMovement){
        
            if(UpButton)
                UpButton.onClick.AddListener(() => playerMovement.Move(Vector3.forward));

            if(DownButton)
                DownButton.onClick.AddListener(() => playerMovement.Move(Vector3.back));

            if(LeftButton)
                LeftButton.onClick.AddListener(() => playerMovement.Move(Vector3.left));

            if(RightButton)
                RightButton.onClick.AddListener(() => playerMovement.Move(Vector3.right));

        }

    }

}
