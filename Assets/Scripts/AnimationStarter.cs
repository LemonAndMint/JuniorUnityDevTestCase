using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStarter : MonoBehaviour
{
    [SerializeField]private Animator _anim;
    [SerializeField]private string _animName;
    public string AnimName {

        get => _animName;

    } 
    [SerializeField]private int _layerNo;

    public void StartSingleAnim(){

        _anim.Play(_animName , _layerNo);

    }
}
