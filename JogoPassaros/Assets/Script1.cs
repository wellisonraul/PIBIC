using System;
using System.Collections;
using UnityEngine;
using Vuforia;

public class Script1 : MonoBehaviour, ITrackableEventHandler{
    private GameObject borboleta1;
    private GameObject placa1;


    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        borboleta1 = GameObject.Find("borboleta1");
        placa1 = GameObject.Find("placa1");
        placa1.SetActive(false);
        mTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (mTrackableBehaviour)
        {
            mTrackableBehaviour.RegisterTrackableEventHandler(this);
        }
    }


    public void OnTrackableStateChanged(
                                    TrackableBehaviour.Status previousStatus,
                                    TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            Debug.Log(Borboleta.escolhaBorboleta);
            if (Borboleta.escolhaBorboleta == 0)
            {
                placa1.SetActive(false);
                borboleta1.SetActive(true);
                borboleta1.GetComponent<Animation>().Play();
                StartCoroutine(Temporizador());
            }
        }
        else
        {
        }
    }

    IEnumerator Temporizador()
    {
        yield return new WaitForSeconds(5);
        borboleta1.GetComponent<Animation>().Stop();
        borboleta1.SetActive(false);
        placa1.SetActive(true);
        Borboleta.escolhaBorboleta = 1;
    }
}
