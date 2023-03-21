using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{ 

    public GameObject HintFirstLevel;
    private bool hasBeenUsedOnLevel;
    

    void Start()
    {
        HintFirstLevel.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            HintFirstLevel.SetActive(true);
        }
    }
}
