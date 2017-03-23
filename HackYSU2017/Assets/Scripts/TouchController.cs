using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchController : MonoBehaviour {

    public OVRInput.Controller controller;
    private bool isWallDown = false;
	// Update is called once per frame
	void Update () {
        transform.localPosition = OVRInput.GetLocalControllerPosition(controller);
        transform.localRotation = OVRInput.GetLocalControllerRotation(controller);


        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Debug.Log("B button was pressed");
            if (!isWallDown)
            {
                isWallDown = true;

                Debug.Log("Lowering Walls");
               // room.GetComponent<Animator>().Play("lowerwalls");
            }
        }
    }



}
