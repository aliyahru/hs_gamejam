using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUman : MonoBehaviour
{
    // Start is called before the first frame update
    Collider2D effect_area;
    public DialougeAsset dialougeAsset;
    public DialougeControl control;

    void Start()
    {
        effect_area = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // List<Collider2D> results = new List<Collider2D>();
        // ContactFilter2D filter = new ContactFilter2D();
        // LayerMask Mask = LayerMask.GetMask("Cat");
        // filter.layerMask = Mask;
        // // filter.SetLayerMask(true);
        // if (Physics2D.OverlapCollider(effect_area, filter, results) > 1) {

        //     UnityEngine.Debug.Log(Physics2D.OverlapCollider(effect_area, filter, results));
        // }
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        UnityEngine.Debug.Log("hold on...");
        if (collider.gameObject.tag == "Cat") {
            control.ShowDialouge(7);
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            UnityEngine.Debug.Log("you faill");
        }
    }
}
