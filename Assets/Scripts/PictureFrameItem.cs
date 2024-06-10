using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PictureFrameItem : InteractableObject{
    public override void Interact(){
        onTriggerEvent.Invoke();
    }
}