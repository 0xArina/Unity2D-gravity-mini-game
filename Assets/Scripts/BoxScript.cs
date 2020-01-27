using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoxScript : MonoBehaviour {

  
    Vector2 getGravity;     
        
    // Use this for initialization
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        //LMB pressed
        if (Input.GetMouseButtonDown(0))
        {
            getGravity = Physics2D.gravity;
            Physics2D.gravity = Vector2.zero;
        }
        //LMB released
        if (Input.GetMouseButtonUp(0))
        {
            Physics2D.gravity = getGravity;
        }
        //mouse tracking
        if (Input.GetMouseButton(0)){
             Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
             RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);

            if (hit.collider != null)
            {
              hit.collider.gameObject.transform.position = hit.point;
            }
        }

    }
}
