using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class btSetaBaixoScript : MonoBehaviour, IVirtualButtonEventHandler {

    private GameObject btSetaBaixo;
    private GameObject placaBaixo;

    // Use this for initialization
    void Start()
    {
        btSetaBaixo = GameObject.Find("btSetaBaixo");
        placaBaixo = GameObject.Find("placaBaixo");
        placaBaixo.SetActive(false);
        btSetaBaixo.GetComponent<VirtualButtonAbstractBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        placaBaixo.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        placaBaixo.SetActive(false);
    }
}
