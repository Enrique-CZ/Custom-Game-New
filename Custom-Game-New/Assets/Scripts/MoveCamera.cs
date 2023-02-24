using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosistion;

    private void Update()
    {
        transform.position = cameraPosistion.position;
    }
}
