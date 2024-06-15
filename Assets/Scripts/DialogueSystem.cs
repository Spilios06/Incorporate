using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour{
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject speechBubble;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private List<String> dialogueLines;
    private int currentLineIndex;
    private TextMeshProUGUI currentLine;
    public void onDialogueStart(){
        character.SetActive(true);
        speechBubble.SetActive(true);
        if (Input.GetKeyDown(KeyCode.Space) && currentLineIndex < dialogueLines.Count){
            DisplayNextDialogue();
        }
    }
    void DisplayNextDialogue(){
        currentLine = new TextMeshProUGUI(){ text = dialogueLines[currentLineIndex] };
        dialogueText.text = currentLine.text;
        currentLineIndex++;
        if (currentLineIndex >= dialogueLines.Count){
            character.SetActive(false);
            speechBubble.SetActive(false);
        }
    }
}