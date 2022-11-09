using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class GameScene: MonoBehaviour {

    public GameObject myObject;

    // Swipe gestures variables
    Vector2 firstPressPos;
    Vector2 secondPressPos;
    Vector2 currentSwipe;

    // Start is called before the first frame update
    void Start(){
    
    }

    // Update is called once per frame
    void Update(){

        // Touch Down
        if (Input.GetMouseButtonDown(0)) {
            // Save began touch 2d point
            firstPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
        }
        
        if (Input.GetMouseButtonUp (0)) {
            ///// SWIPE GESTURES /////
            secondPressPos = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
            currentSwipe = new Vector2(secondPressPos.x - firstPressPos.x, secondPressPos.y - firstPressPos.y);
                            
            // Swipe UP
            if(currentSwipe.y > 120) { print("up swipe"); 
                myObject.transform.position = new Vector3(myObject.transform.position.x, myObject.transform.position.y + 1f, myObject.transform.position.z);
            }
        
            // Swipe DOWN
            if(currentSwipe.y < -120){ print("down swipe"); 
                myObject.transform.position = new Vector3(myObject.transform.position.x, myObject.transform.position.y - 1f, myObject.transform.position.z);
            }
        
            // Swipe LEFT
            if(currentSwipe.x < -120){ print("left swipe"); 
                myObject.transform.position = new Vector3(myObject.transform.position.x - 1f, myObject.transform.position.y, myObject.transform.position.z);
            }
        
            // Swipe RIGHT
            if(currentSwipe.x > 120){ print("right swipe"); 
                myObject.transform.position = new Vector3(myObject.transform.position.x + 1f, myObject.transform.position.y, myObject.transform.position.z);
            }
        } //./ TouchUp

    } // ./ Update()



}// ./ end
