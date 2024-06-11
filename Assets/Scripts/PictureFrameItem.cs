using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class PictureFrameItem : InteractableObject{
    [SerializeField] private TextMeshProUGUI inspectMessage;
    [SerializeField] private float fadeDuration = 1f;
    private float alpha;
    private float elapsedTime;
    public override void Interact(){
        onTriggerEvent.Invoke();
    }
    public void fadeInText(){
        StartCoroutine(fadeIn());
    }
    private IEnumerator fadeIn(){
        elapsedTime = 0f;
        Color originalColor = inspectMessage.color;
        while (elapsedTime < fadeDuration){
            elapsedTime += Time.deltaTime;
            alpha = Mathf.Clamp01(elapsedTime / fadeDuration);
            inspectMessage.color = new Color(originalColor.r, originalColor.g, originalColor.b, alpha);
            yield return null;
        }
    }
}