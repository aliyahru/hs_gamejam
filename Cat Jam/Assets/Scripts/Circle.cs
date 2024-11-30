using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using UnityEngineInternal;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D body;
    float horizontal;
    float vertical;

    Vector2 lastDir;

    Boolean isMoving = false;
    public float runSpeed = 20.0f;

    Vector2 stopped;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        lastDir = new Vector2(0, 0);
        stopped = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        // if (Raytest()) {
        //     UnityEngine.Debug.Log("O");
        //     // UnityEngine.Debug.Log("raytest");
        // }
        if (Input.GetKeyDown("space")) {
            UnityEngine.Debug.Log("space");
            if (Raytest()) {
                UnityEngine.Debug.Log("helllo i am the spirit");
            }
        }
        
    }

    private void FixedUpdate() {
        body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed);
        
        if (body.velocity != stopped) {
            lastDir = body.velocity;
        }
        // UnityEngine.Debug.Log(body.velocity);

    }
    
    public Boolean Raytest() {
        float raydist = 2f;
        RaycastHit2D foundHit = Physics2D.Raycast(transform.position, lastDir, raydist, LayerMask.GetMask("Interactable"));
        UnityEngine.Debug.DrawRay(transform.position, lastDir * raydist, Color.white, 0);

        if (foundHit.collider != null) {
            UnityEngine.Debug.Log(body.velocity);
            if (foundHit.collider.gameObject.tag == "Spirit") {
                // UnityEngine.Debug.Log("hellooo i am the spirit");
                return true;
            }
        }
        return false;
    }
}
