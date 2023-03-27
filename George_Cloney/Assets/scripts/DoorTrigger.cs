using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DoorTrigger : MonoBehaviour
{
    public UnityEvent Ontrigger;
    public UnityEvent OntriggerLeft;

    private void OnTriggerEnter(Collider other)
    {
        Ontrigger.Invoke();
        //if (isOpened1 == false)
        //{

        //    isOpened1 = true;
        //    door.transform.position += new Vector3(0, 3, 0);
        //}
    }

    private void OnTriggerExit(Collider other)
    {
        OntriggerLeft.Invoke();

        //if (isOpened1 == true)
        //{
        //    isOpened1 = false;
        //    door.transform.position -= new Vector3(0, 3, 0);
        //}
    }
}