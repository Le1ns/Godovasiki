using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RightOne : MonoBehaviour
{

    private GameObject mainText;

    void Start()
    {
        mainText = GameObject.Find("MeinText");
    }

    void OnMouseUp()
    {
        if (GetComponent<Renderer>().material.color == mainText.GetComponent<Text>().color)
            mainText.GetComponent<Color2>().next = true;
        else
           mainText.GetComponent<Color2>().lose = true;
    }
}