using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class UnitMovementManager : MonoBehaviour{
    public void MoveUnit(List<GameObject> units){
        Ray ray = Camera.main.ScreenPointToRay(Mouse.current.position.ReadValue());
        foreach (var unit in units){
            UnitMovement unitMovment = unit.GetComponent<UnitMovement>();
            if (Physics.Raycast(ray, out RaycastHit hit)){
                NavMeshHit navMeshHit;
                if (NavMesh.SamplePosition(hit.point, out navMeshHit, float.MaxValue, NavMesh.AllAreas)){
                    //InvokeUnitMove(agent, animator);
                    unitMovment.Move(navMeshHit);
                }
            }
        }
    }
}