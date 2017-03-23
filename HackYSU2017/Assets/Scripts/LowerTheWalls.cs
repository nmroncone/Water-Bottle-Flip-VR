using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerTheWalls : MonoBehaviour {
    
    private bool isWallDown = false;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update () {

        if (Input.GetButton("lower walls") == true)
        {
            Debug.Log("Lowering Walls Button Pressed");
            if (!isWallDown)
            {
                isWallDown = true;
                anim.SetBool("isButtonPressed", true);
                Debug.Log("Lowering Walls");
               
            }
        }
        
    }
}
