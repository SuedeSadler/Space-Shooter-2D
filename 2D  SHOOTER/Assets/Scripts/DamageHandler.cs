using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHandler : MonoBehaviour{
    public int health = 1;
    public float invlnPeriod = 0;
    float invulnTimer = 0;
    int correctLayer;

    void Start(){
        correctLayer = gameObject.layer;
    }
    void OnTriggerEnter2D() {
        Debug.Log ("Trigger!!");
    
        health--;
        invulnTimer = invlnPeriod;
        gameObject.layer = 8;
        
    }

    void Update() {

        invulnTimer -= Time.deltaTime;
        if(invulnTimer <= 0){
            gameObject.layer = correctLayer;
        }
        if(health <= 0) {
             Die();
        }
    }

    void Die() {
        Destroy(gameObject);
    }
}
     
        
        
        
    

  


