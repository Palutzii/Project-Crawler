using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour{
    
    
    [SerializeField] GameObject generateWall;
    [SerializeField] GameObject player;

    public NavMeshSurface surface;
    
    bool _playerSpawned = false;

    void Start(){
        
        //Generate level
        
        // Update NavmMesh
        surface.BuildNavMesh();
    }
}
