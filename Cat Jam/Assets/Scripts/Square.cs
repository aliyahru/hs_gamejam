using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class Square : MonoBehaviour
{
    public DialougeAsset dialouge;

    // Start is called before the first frame update
    void Start()
    {
        DialougeControl dialougeControl = gameObject.AddComponent<DialougeControl>();
        dialougeControl.ShowDialouge("Bean");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
