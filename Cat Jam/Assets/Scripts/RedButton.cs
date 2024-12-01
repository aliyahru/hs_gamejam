using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    public DialougeAsset dialougeAsset;
    public DialougeControl control;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Boolean OnPress(GameObject pressObject) {
        if (pressObject.GetComponent<ObjectPickup>().getMass() < 5f ) {
            UnityEngine.Debug.Log("Object is too light!");
            return false;
        } else {
            UnityEngine.Debug.Log("Wow! stupid fffuckin cat");
            control.ShowDialouge(6);
            return true;
        }
    }
}
