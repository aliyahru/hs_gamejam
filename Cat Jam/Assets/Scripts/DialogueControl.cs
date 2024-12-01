using System.Collections;
using TMPro;
using UnityEngine;

public class DialougeControl : MonoBehaviour
{
    public GameObject ghost;
    public DialougeAsset dialougeAsset;
    [SerializeField] TextMeshProUGUI dialougeText;
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject dialougePanel;

    float charPerSec = 20;
    public void ShowDialouge(int elementNum)
    {
        string dialouge = dialougeAsset.dialouge[elementNum];
        string textBuffer = null;

        StartCoroutine(TypeOut(textBuffer, dialouge));

        nameText.text = dialougeAsset.character + ":";

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
        nameText.text = null;
        dialougeText.text = null; ;
        dialougePanel.SetActive(false);
        ghost.SetActive(false);
    }
}