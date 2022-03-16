using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour{

    Animator _animator;
    NavMeshAgent pathfinder;
    [SerializeField] Transform target;

    void Start(){
        pathfinder = GetComponent<NavMeshAgent>();
        _animator = GetComponent<Animator>();
    }

    void Update(){
        
        _animator.SetBool("isWalking", true);
        pathfinder.SetDestination(target.position);
        _animator.SetBool("isWalking", false);
    }
}
