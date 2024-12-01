using UnityEngine;

public class Square : MonoBehaviour
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
        if (Input.GetKeyDown("e"))
        {
            //control.ShowDialouge(0);
        }
    }
}
