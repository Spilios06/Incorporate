using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ComputerItem : InteractableObject{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float minViewportSize;
    private float newViewportSize;
    private float startTime;
    public override void Interact(){
        //StartCoroutine(zoomIn());
        onTriggerEvent.Invoke();
    }
    private IEnumerator zoomIn(){
        startTime = Time.time;
        while (Time.time < startTime + 0.5f){
            float t = (Time.time - startTime) / 0.5f;
            float newViewportSize = Mathf.Lerp(5.392406f, minViewportSize, t);
            playerCamera.orthographicSize = newViewportSize;
            yield return null;
        }
        playerCamera.orthographicSize = 5.392406f;
    }
}