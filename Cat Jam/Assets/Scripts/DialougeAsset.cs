using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class DialougeAsset : ScriptableObject
{
    [TextArea]
    public string name;
    public string[] dialouge;
}
