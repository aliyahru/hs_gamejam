using System.Collections;
using TMPro;
using UnityEngine;

public class DialougeControl : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI dialougeText;
    //[SerializeField] TextMeshProUGUI dialougeText;
    //[SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject dialougePanel;

    float charPerSec = 10;
    public void ShowDialouge(string dialouge)
    {
        string textBuffer = null;

        StartCoroutine(TypeOut(textBuffer, dialouge));

        //nameText.text = name + "...";

        dialougePanel.SetActive(true);
    }

    IEnumerator TypeOut(string textBuffer, string dialouge)
    {
        foreach (char c in dialouge)
        {
            textBuffer += c;
            dialougeText.text = textBuffer;
            yield return new WaitForSeconds(1 / charPerSec);
        }
    }

    public void EndDialouge()
    {
        //nameText.text = null;
        dialougeText.text = null; ;
        dialougePanel.SetActive(false);
    }
}