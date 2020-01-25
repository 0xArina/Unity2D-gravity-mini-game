using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gravityTextScript : MonoBehaviour {

    public Text gravityText;

    // Use this for initialization
    void Start () {
        gravityText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            gravityText.text = "gravity off";
        }

        if (Input.GetMouseButtonUp(0))
        {
            gravityText.text = "gravity on";
        }
    }
}
