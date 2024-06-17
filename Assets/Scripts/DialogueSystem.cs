using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class DialogueSystem : MonoBehaviour{
    [SerializeField] private GameObject character;
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private List<String> dialogueLines;
    private int currentLineIndex = 0;
    private bool isDialogueActive;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space) && isDialogueActive){
            DisplayNextDialogue();
        }
    }
    public void onDialogueStart(){
        character.SetActive(true);
        DisplayNextDialogue();
        isDialogueActive = true;
    }
    private void DisplayNextDialogue(){
        dialogueText.text = dialogueLines[currentLineIndex];
        currentLineIndex++;
        if (currentLineIndex >= dialogueLines.Count){
            character.SetActive(false);
        }
    }
}