using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public interface IInteractable{ public void Interact(); }
public abstract class InteractableObject : MonoBehaviour, IInteractable{
    public UnityEvent onTriggerEvent;
    public abstract void Interact();
    public void OnMouseDown(){
        Interact();
    }
}