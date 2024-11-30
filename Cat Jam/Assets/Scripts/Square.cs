using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEngine;

public class Square : MonoBehaviour
{
    public DialougeAsset dialougeAsset;
    public DialougeControl control;

    // Start is called before the first frame update
    void Start()
    {
        control.ShowDialouge(dialougeAsset.dialouge[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
