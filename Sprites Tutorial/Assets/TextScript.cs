using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
		textComponent.text = state.GetText();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.UpArrow)){
            textComponent.text = ("You hit the Up Arrow");
        }else if(Input.GetKeyDown(KeyCode.DownArrow)){
            textComponent.text = ("You hit the Down Arrow");
        }else if(Input.GetKeyDown(KeyCode.Return)){
            textComponent.text = ("You hit Enter");
        }
	}
}
