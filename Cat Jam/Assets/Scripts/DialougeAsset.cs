using UnityEngine;

[CreateAssetMenu]
public class DialougeAsset : ScriptableObject
{
    [TextArea]
    public string character;
    public string[] dialouge;
}
