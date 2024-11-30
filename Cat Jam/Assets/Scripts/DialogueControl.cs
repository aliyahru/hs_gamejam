using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialougeControl : MonoBehaviour 
{
    [SerializeField] TextMeshProUGUI dialougeText;
    //[SerializeField] TextMeshProUGUI dialougeText;
    //[SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject dialougePanel;

    public void ShowDialouge(string? dialouge)
    {
        //nameText.text = name + "...";
        dialougeText.text = dialouge;
        dialougePanel.SetActive(true);
    }

    public void EndDialouge()
    {
        //nameText.text = null;
        dialougeText.text = null; ;
        dialougePanel.SetActive(false);
    }
}