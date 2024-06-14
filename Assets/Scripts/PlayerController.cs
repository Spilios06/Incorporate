using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour{
    [SerializeField] private ComputerItem computer;
    public float sanityMeter = 0f;
    void Update(){
        if(sanityMeter >= 100) gameOver();
    }
    public void gameOver(){
        
    }
    public void cleanSpread(){
        computer.computerState -= 1;
        computer.switchState();
    }
}