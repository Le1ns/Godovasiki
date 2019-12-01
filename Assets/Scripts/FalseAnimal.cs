using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseAnimal : MonoBehaviour {
    public GameObject pLost;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseUp()
    {
        pLost.SetActive(true);
    }
}
