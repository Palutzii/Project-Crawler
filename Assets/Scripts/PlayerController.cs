using System;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour{

    [SerializeField] Camera cam;
    [SerializeField] NavMeshAgent agent;

    Animator _animator;

    void Start(){
        _animator = GetComponent<Animator>();
    }

    void Update(){

        if (Input.GetMouseButtonDown(0)){
        
            Ray ray = cam.ScreenPointToRay(Input.mousePosition); 
            RaycastHit hit;
        
            if (Physics.Raycast(ray, out hit)){
                //Move
                agent.SetDestination(hit.point);
            }
                    
        }
    }
}
