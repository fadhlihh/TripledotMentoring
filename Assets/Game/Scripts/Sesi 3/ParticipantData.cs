using System;
using System.Collections.Generic;
using UnityEngine;

public class ParticipantData : MonoBehaviour
{
    [SerializeField]
    List<string> participant = new List<string>();

    private void Start()
    {
        bool isPhoebeExsist = participant.Contains("Phoebe");
        Debug.Log(isPhoebeExsist);
    }

    private void Update()
    {
        // bool isSpaceDetected = Input.GetKeyDown(KeyCode.Space);
        // if (isSpaceDetected)
        // {
        //     participant.Add("Peter");
        //     foreach (string element in participant)
        //     {
        //         Debug.Log(element);
        //     }
        //     participant.Remove("Phoebe");
        // }

    }
}
