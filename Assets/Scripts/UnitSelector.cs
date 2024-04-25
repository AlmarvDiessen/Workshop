using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;

public class UnitSelector : MonoBehaviour{

    // track a list of all current units
    // track a list of selected units

    // create a RectTransform for the selection box.
    // cache mouse position.

    //create a public property for the selected units.
    public List<GameObject> SelectedUnits => _selectedUnits;
    
    private event Action _onBoxDragEvent;

    private UnitSelectionActions _unitSelection;
    private WaitForEndOfFrame _endOfFrame;
    private Coroutine _onDragCoroutine = null;


    private void Awake(){
        _unitSelection = new UnitSelectionActions();
        _endOfFrame = new WaitForEndOfFrame();
        _onBoxDragEvent += SelectionBox;
        _onBoxDragEvent += DeselectUnits;
        _onBoxDragEvent += SelecUnits;
    }

    private void OnEnable(){
        _unitSelection.Enable();
        _unitSelection.Unit.Selection.performed += DragSelect;
        _unitSelection.Unit.Selection.started += DragSelect;
        _unitSelection.Unit.Selection.canceled += DragSelect;
    }


    private void OnDisable(){
        _unitSelection.Disable();
        _unitSelection.Unit.Selection.performed -= DragSelect;
        _unitSelection.Unit.Selection.started -= DragSelect;
        _unitSelection.Unit.Selection.canceled -= DragSelect;
    }

    private void DragSelect(InputAction.CallbackContext obj){
        //check if we clicked and if the Coroutine is null
        //store current mouse position
        // cache and our start Coroutine 

        IEnumerator OnDragHold(){
            yield return new WaitUntil(obj.ReadValueAsButton);
            //read while we are holding the mouse down   
            //invoke the boxDragEvent when holding the mouse down


            yield return _endOfFrame;
            //deactivate the box when done dragging the mouse.
            //clear _onDragCoroutine 
        }
    }

    private void SelectionBox(){
        // activate the selection box

        //calculate the box width and height based on mouse postion and cache these values.


        //size the selection box 
        //calculate and anchor the box to the you stored mouse position
    }

    private void SelecUnits(){
        // loop through each unit
          
            //cache the unit's postion from world to the screen.
            
            //check if the unit is inside the selection box
                
                //add the unit to the selected unit list.
                //activate the selection marker.
    }

    private bool BoxContainsUnit(Vector3 unitToScreenPosition){
        //calculate the minimum corner and maximum corner of the box.
        
        // if the unit position is with in the box return true
        
        return false;
    }

    private void DeselectUnits(){
        
        // loop through the selected units
            //disable the selection marker.


        //clear the selected units for the next time we want to select units.
  
    }
}