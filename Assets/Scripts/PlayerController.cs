using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
public class PlayerController : MonoBehaviour{
    [SerializeField] private ComputerItem computer;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private GameObject gameManager;
    private float sanityMeter = 0f;
    private Coroutine sanityCoroutine;
    void Update(){
        if(sanityMeter >= 100) gameOver();
        if(Input.GetKeyDown(KeyCode.E)){
            cleanSpread();
        }
    }
    public void gameOver(){
        gameManager.SetActive(false);
        deathScreen.SetActive(true);
    }
    public void cleanSpread(){
        computer.computerState -= 1;
        computer.switchState();
        CheckComputerState();
    }
    public void setSanity(int value){
        sanityMeter = value;
    }
    public void CheckComputerState(){
        if (sanityCoroutine != null){
            StopCoroutine(sanityCoroutine);
        }
        if (computer.computerState > 0){
            sanityCoroutine = StartCoroutine(IncreaseSanityOverTime());
        }
        else{
            sanityCoroutine = StartCoroutine(DecreaseSanityOverTime());
        }
    }
    private IEnumerator IncreaseSanityOverTime(){
        while (true){
            sanityMeter += Time.deltaTime;
            yield return null;
        }
    }
    private IEnumerator DecreaseSanityOverTime(){
        while (true){
            sanityMeter -= Time.deltaTime;
            if (sanityMeter < 0) sanityMeter = 0;
            yield return null;
        }
    }
    public bool passwordChecker(string password){
        if (password == "786") return true;
        else return false;
    }
}