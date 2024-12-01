using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPickup : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float mass;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float getMass() {
        return mass;
    }
    // void objectAttach(object) {
    //     GetComponent<FixedJoint2D>.
    // }
}
