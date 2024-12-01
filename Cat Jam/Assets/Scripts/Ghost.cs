using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    public DialougeAsset dialougeAsset;
    public DialougeControl control;
    int diaNum = 2;

    // Start is called before the first frame update
    void Start()
    {
        control.ShowDialouge(1);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r") && diaNum <= 5)
        {
            control.ShowDialouge(diaNum);
            diaNum++;
        }
        else if (Input.GetKeyDown("r") && diaNum > 5)
        {
            control.EndDialouge();
        }
    }
}
