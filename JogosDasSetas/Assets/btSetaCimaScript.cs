using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia; 

public class btSetaCimaScript : MonoBehaviour, IVirtualButtonEventHandler
{

    private GameObject btSetaCima;
    private GameObject placaCima;
    

    // Use this for initialization
    void Start()
    {
        btSetaCima = GameObject.Find("btSetaCima");
        placaCima = GameObject.Find("placaCima");
        placaCima.SetActive(false);
        btSetaCima.GetComponent<VirtualButtonAbstractBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        placaCima.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        placaCima.SetActive(false);
    }
}
