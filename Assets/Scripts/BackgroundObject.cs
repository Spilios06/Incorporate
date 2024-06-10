using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class BackgroundObject : InteractableObject{
    public override void Interact(){
        onTriggerEvent.Invoke();
    }
}