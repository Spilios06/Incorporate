using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ComputerItem : InteractableObject{
    [SerializeField] private Camera playerCamera;
    [SerializeField] private float minViewportSize;
    [SerializeField] private Sprite computerDefaultState, computerStageOne, computerStageTwo, computerStageThree;
    [SerializeField] private Sprite deskPhoneDefaultState, deskPhoneStageOne, deskPhoneStageTwo, deskPhoneStageThree;
    [SerializeField] private Sprite keyboardDefaultState, keyboardStageOne, keyboardTwo;
    [SerializeField] private Sprite mouseDefaultState, mouseStageOne, mouseStageTwo;
    [SerializeField] private GameObject keyboard, mouse, deskPhone;
    private float newViewportSize;
    private float startTime;
    private bool turnedOn = false;
    public int computerState = 0;
    public void switchState(){
        switch (computerState){
            case 0:
                GetComponent<SpriteRenderer>().sprite = computerDefaultState;
                keyboard.GetComponent<SpriteRenderer>().sprite = keyboardDefaultState;
                mouse.GetComponent<SpriteRenderer>().sprite = mouseDefaultState;
                deskPhone.GetComponent<SpriteRenderer>().sprite = deskPhoneDefaultState;
                break;
            case 1:
                GetComponent<SpriteRenderer>().sprite = computerStageOne;
                keyboard.GetComponent<SpriteRenderer>().sprite = keyboardStageOne;
                mouse.GetComponent<SpriteRenderer>().sprite = mouseStageOne;
                deskPhone.GetComponent<SpriteRenderer>().sprite = deskPhoneStageOne;
                break;
            case 2:
                GetComponent<SpriteRenderer>().sprite = computerStageTwo;
                keyboard.GetComponent<SpriteRenderer>().sprite = keyboardTwo;
                mouse.GetComponent<SpriteRenderer>().sprite = mouseStageTwo;
                deskPhone.GetComponent<SpriteRenderer>().sprite = deskPhoneStageTwo;
                break;
            case 3:
                GetComponent<SpriteRenderer>().sprite = computerStageThree;
                deskPhone.GetComponent<SpriteRenderer>().sprite = deskPhoneStageThree;
                break;
        }
    }
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