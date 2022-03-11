using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour{
    
    NavMeshAgent pathfinder;
    [SerializeField] Transform target;

    void Start(){
        pathfinder = GetComponent<NavMeshAgent>();
    }

    void Update(){
        pathfinder.SetDestination(target.position);
    }
}
