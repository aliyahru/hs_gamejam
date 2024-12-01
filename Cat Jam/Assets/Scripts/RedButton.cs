using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public DialougeAsset dialougeAsset;
    public DialougeControl control;
    bool button = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r") && button == true)
        {
            control.EndDialouge();
        }
    }

    public Boolean OnPress(GameObject pressObject) {
        if (pressObject.GetComponent<ObjectPickup>().getMass() < 5f ) {
            UnityEngine.Debug.Log("Object is too light!");
            return false;
        } else {
            control.ShowDialouge(6);
            button = true;
            return true;
        }
    }
}
