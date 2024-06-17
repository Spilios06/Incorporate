using UnityEngine;
public class NumberSequenceChecker : MonoBehaviour{
    [SerializeField] GameObject imageThing;
    private int[] targetSequence = { 7, 8, 6 };
    private int currentSequenceIndex = 0;
    void Update(){
        if (Input.GetKeyDown(KeyCode.Alpha7)){
            CheckSequence(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8)){
            CheckSequence(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6)){
            CheckSequence(6);
        }
    }
    void CheckSequence(int number){
        if (number == targetSequence[currentSequenceIndex]){
            currentSequenceIndex++;
            if (currentSequenceIndex >= targetSequence.Length){
                OnSequenceComplete();
                currentSequenceIndex = 0;
            }
        }
        else{
            currentSequenceIndex = 0;
        }
    }
    void OnSequenceComplete(){
        imageThing.SetActive(true);
    }
}