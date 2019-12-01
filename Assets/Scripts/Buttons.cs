using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour {
    public Sprite button1,button;
    public string action,nameScene;
    

    private void OnMouseDown()
    {
        GetComponent<SpriteRenderer>().sprite = button1;
    }
    private void OnMouseUp()
    {  
        GetComponent<SpriteRenderer>().sprite = button;
    }
   /* private void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "Play":
                Application.LoadLevel("levels");
                break;
            case "Rating":
                Application.OpenURL("http://google.com");
                break;
           

          
        }       
    }*/
}
