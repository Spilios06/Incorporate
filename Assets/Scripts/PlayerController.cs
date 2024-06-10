using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour{
    private float sanityMeter = 0f;
    void Start(){
        
    }
    void Update(){
        if(sanityMeter >= 100) gameOver();
    }
    public void setSanityMeter(int value){ sanityMeter = value; }
    public void gradualSanityIncrease(){
        sanityMeter += 2 * Time.deltaTime;
    }
    public void gradualSanityDecrease(){
        sanityMeter -= 1 * Time.deltaTime;
    }
    public void gameOver(){
        
    }
}