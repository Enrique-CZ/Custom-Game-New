using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{

    public GameObject box;

    // Start is called before the first frame update
    void Start()
    {
        box.SetActive(false);   
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                box.SetActive(true);
            }
        }
    }
}
