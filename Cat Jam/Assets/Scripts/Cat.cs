using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using UnityEditor;
using UnityEngine;
using UnityEngineInternal;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D body;
    float horizontal;
    float vertical;

    Vector2 lastDir;

    Boolean isMoving = false;
    public float runSpeed = 20.0f;

    Vector2 stopped;

    [SerializeField] Animator cAnimator;


    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        lastDir = new Vector2(0, 0);
        stopped = new Vector2(0, 0);

        cAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");

        cAnimator.SetFloat("Horizontal", horizontal);
        cAnimator.SetFloat("Vertical", vertical);

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

<<<<<<< Updated upstream
=======
        if (Input.GetKeyDown("return")) {


            UnityEngine.Debug.Log("helllo i am the spirit");
            

            if (currentlyHolding != null) {
                RaycastHit2D foundHit = Physics2D.Raycast(transform.position, lastDir, 2f, LayerMask.GetMask("Button"));
                if (foundHit.collider != null) {
                    if (foundHit.collider.gameObject.tag == "Button") {
                        foundHit.collider.gameObject.GetComponent<RedButton>().OnPress(currentlyHolding);
                    }
                }
                else {
                    currentlyHolding.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
                    currentlyHolding.GetComponent<FixedJoint2D>().connectedBody = null;
                    currentlyHolding = null;
                }
            } else {
                objectPickup();
            }
        }

>>>>>>> Stashed changes
        if (cAnimator != null) {
            if (body.velocity != stopped) {
                if (body.velocity[0] > 0) {
                    cAnimator.SetTrigger("WalkR");
                }
                else if (body.velocity[0] < 0) {
                    cAnimator.SetTrigger("WalkL");
                }
                else if (body.velocity[1] > 0) {
                    cAnimator.SetTrigger("WalkU");
                }
                else if (body.velocity[1] < 0) {
                    cAnimator.SetTrigger("WalkD");
                }
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

        if (foundHit.collider != null) {
            // UnityEngine.Debug.Log(body.velocity);
            if (foundHit.collider.gameObject.tag == "Spirit") {
                // UnityEngine.Debug.Log("hellooo i am the spirit");
                return true;
            }
        }
        return false;
    }
<<<<<<< Updated upstream
=======

    public void objectPickup() {
        float raydist = 2f;
        RaycastHit2D foundHit = Physics2D.Raycast(transform.position, lastDir, raydist, LayerMask.GetMask("Interactable"));



        if (foundHit.collider != null) {
            UnityEngine.Debug.Log(body.velocity);
            if (foundHit.collider.gameObject.tag == "Object") {
                // UnityEngine.Debug.Log("hellooo i am the spirit");
                UnityEngine.Debug.Log(foundHit.collider.gameObject);
                currentlyHolding = foundHit.collider.gameObject;
                currentlyHolding.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                currentlyHolding.GetComponent<FixedJoint2D>().connectedBody = GetComponent<Rigidbody2D>();
                // currentlyHolding.objectAttach(this);

            }
        }
    }

>>>>>>> Stashed changes
}
