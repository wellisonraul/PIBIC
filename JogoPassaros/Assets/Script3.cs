using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Script3 : MonoBehaviour, ITrackableEventHandler
{
    private GameObject borboleta3;
    private GameObject placa3;

    private TrackableBehaviour mTrackableBehaviour;

    void Start()
    {
        borboleta3 = GameObject.Find("borboleta3");
        placa3 = GameObject.Find("placa3");
        borboleta3.SetActive(false);
        placa3.SetActive(true);


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
            if (Borboleta.escolhaBorboleta == 2)
            {
                placa3.SetActive(false);
                borboleta3.SetActive(true);
                borboleta3.GetComponent<Animation>().Play();
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
        borboleta3.GetComponent<Animation>().Stop();
        borboleta3.SetActive(false);
        placa3.SetActive(true);
        Borboleta.escolhaBorboleta = 0;
    }
}
