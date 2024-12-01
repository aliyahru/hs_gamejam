using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Boolean OnPress(GameObject pressObject) {
        if (pressObject.GetComponent<Rigidbody2D>().mass < 5 ) {
            UnityEngine.Debug.Log("Object is too light!");
            return false;
        } else {
            UnityEngine.Debug.Log("Wow! stupid fffuckin cat");
            return true;
        }
    }
}
