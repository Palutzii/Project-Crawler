using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class PlayerCombat : MonoBehaviour{

    public Animator _animator;
    public Transform attackPoint;
    public float attackRange = .5f;
    public LayerMask enemyLayers;
    
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Attack();
        }
    }

    void Attack(){
        //Play an attack animation
        _animator.SetTrigger("Attack");
        
        //Detect enemies in range of attack
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        
        //Damage them
        foreach (Collider enemy in hitEnemies){
            Debug.Log("We hit " + enemy.name);
        }
    }

    void OnDrawGizmosSelected(){
        if (attackPoint == null){
            return;
            
        }
        Gizmos.DrawWireSphere(attackPoint.position,attackRange);
    }
}
