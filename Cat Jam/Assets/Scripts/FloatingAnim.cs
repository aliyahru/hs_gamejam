using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingAnim : MonoBehaviour
{
    public float amplitude = 0.5f;
    public float frequency = 1f;
    Vector3 startOrigin = new Vector3();
    Vector3 floatPos = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        startOrigin = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        floatPos = startOrigin;
        floatPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = floatPos;
    }
}
