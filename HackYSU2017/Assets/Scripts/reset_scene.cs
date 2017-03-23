using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reset_scene : MonoBehaviour {
   

    // Update is called once per frame
    void Update () {

        // if I hit this button then reset the scene.	
        if (Input.GetButton("reset") == true) 
        {
            Debug.Log("A was pressed");
            SceneManager.LoadScene(0);
        }

        /*
        if (OVRInput.Get(OVRInput.Button.One))
        {
            Debug.Log("A was pressed");
        }
        */
	}
}
