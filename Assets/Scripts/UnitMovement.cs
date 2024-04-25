using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class UnitMovement : MonoBehaviour{
    private Animator _animator;
    private NavMeshAgent _agent;

    private void Awake(){
        _animator = GetComponent<Animator>();
        _agent = GetComponent<NavMeshAgent>();
    }

    private void Update(){
        if (_agent.velocity.magnitude < 0.15f){
            _animator.SetFloat("Vertical", 0f);
        }
    }


    public void Move(NavMeshHit hit){
        _agent.SetDestination(hit.position);

        float value = 0f;
        StartCoroutine(Increase());
        _animator.SetFloat("Vertical", 0);

        IEnumerator Increase(){
            while (value < 1f){
                value += 0.25f * (_agent.speed * Time.deltaTime) / 2;
                _animator.SetFloat("Vertical", value);

                yield return null;
            }

            value = 1f;
            _animator.SetFloat("Vertical", value);
        }
    }
}