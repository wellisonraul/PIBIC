using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class btSetaDireitaScript : MonoBehaviour, IVirtualButtonEventHandler {
    private GameObject btSetaDireita;
    private GameObject placaDireita;
    
    // Use this for initialization
    void Start () {
        btSetaDireita = GameObject.Find("btSetaDireita");
        placaDireita = GameObject.Find("placaDireita");
        placaDireita.SetActive(false);
        btSetaDireita.GetComponent<VirtualButtonAbstractBehaviour>().RegisterEventHandler(this);
	}

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        placaDireita.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        placaDireita.SetActive(false);
    }
}
