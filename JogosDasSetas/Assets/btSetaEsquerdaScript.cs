using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class btSetaEsquerdaScript : MonoBehaviour, IVirtualButtonEventHandler  {

    private GameObject btSetaEsquerda;
    private GameObject placaEsquerda;

    // Use this for initialization
    void Start()
    {
        btSetaEsquerda = GameObject.Find("btSetaEsquerda");
        placaEsquerda = GameObject.Find("placaEsquerda");
        placaEsquerda.SetActive(false);
        btSetaEsquerda.GetComponent<VirtualButtonAbstractBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed(VirtualButtonAbstractBehaviour vb)
    {
        placaEsquerda.SetActive(true);

    }

    public void OnButtonReleased(VirtualButtonAbstractBehaviour vb)
    {
        placaEsquerda.SetActive(false);
    }
}
