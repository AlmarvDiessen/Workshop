using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour{
    [SerializeField] private UnitMovementManager m_uMovementManager;
    private UnitSelector m_UnitSelector;


    private void Awake(){
        m_uMovementManager = gameObject.AddComponent<UnitMovementManager>();
        m_UnitSelector = gameObject.GetComponent<UnitSelector>();
    }


    private void Update(){
        if (Input.GetMouseButtonDown(1))
            m_uMovementManager.MoveUnit(m_UnitSelector.SelectedUnits);
    }
}