using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLevel : MonoBehaviour
{
    public GameObject Stick;
    public GameObject Rock;

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "StickKey" && test.gameObject.tag == "RockKey")
        {
            
                Debug.Log("IT WORKED");
        }
        else
        {
            Debug.Log("No");
        }

    }


}
