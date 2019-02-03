using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour {

    public WordManager wordManager;
	
	// Update is called once per frame
	void Update () {
        //laat alle letters zien die er getypt worden op het toetsenbord
        foreach (char letter in Input.inputString)
        {
            wordManager.TypeLetter(letter);
        }
          	
	}
}
