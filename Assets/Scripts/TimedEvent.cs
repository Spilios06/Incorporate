using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class TimedEvent : MonoBehaviour{
    [SerializeField] private UnityEvent timedEvent;
    [SerializeField] private float delayTime;
    public void StartEventWithDelay(){
        StartCoroutine(ExecuteEventAfterDelay());
    }
    private IEnumerator ExecuteEventAfterDelay(){
        yield return new WaitForSeconds(delayTime);
        timedEvent.Invoke();
    }
}