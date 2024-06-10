using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerItem : InteractableObject{
    public override void Interact(){
        onTriggerEvent.Invoke();
    }
}