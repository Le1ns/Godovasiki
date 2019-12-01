using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivDeactiv : MonoBehaviour {



    public GameObject deactiv, activ;
    private void OnMouseUp()
    {
        deactivation(deactiv);
        Activation(activ);
    }
    public void deactivation(GameObject deactiv)
    {
        deactiv.SetActive(false);
    }
    public void Activation(GameObject activ)
    {
        activ.SetActive(true);

    }
}


