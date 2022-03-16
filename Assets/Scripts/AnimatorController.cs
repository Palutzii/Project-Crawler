using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour{
    Animator _animator;

    int isMovingHash;

    void Start(){
        _animator = GetComponent<Animator>();
        isMovingHash = Animator.StringToHash("IsMoving");

    }

    void Update(){

        bool isMoving = _animator.GetBool(isMovingHash);
        bool pressedMove = Input.GetMouseButtonDown(0);

        if (!isMoving && pressedMove){
            _animator.SetBool(isMovingHash, true);
        }

        if (isMoving && !pressedMove){
            _animator.SetBool(isMovingHash, false);
        }
    }
}
