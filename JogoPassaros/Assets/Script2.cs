using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Script2 : MonoBehaviour, ITrackableEventHandler
{
    private GameObject borboleta2;
    private GameObject placa2;

    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        borboleta2 = GameObject.Find("borboleta2");
        borboleta2.SetActive(false);
        placa2 = GameObject.Find("placa2");
        placa2.SetActive(true);


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
            if (Borboleta.escolhaBorboleta == 1)
            {
                placa2.SetActive(false);
                borboleta2.SetActive(true);
                borboleta2.GetComponent<Animation>().Play();
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
        borboleta2.GetComponent<Animation>().Stop();
        borboleta2.SetActive(false);
        placa2.SetActive(true);
        Borboleta.escolhaBorboleta = 2;
    }

}
