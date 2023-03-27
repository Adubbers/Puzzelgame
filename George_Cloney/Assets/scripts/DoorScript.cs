using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    int TriggersToOpen = 2;
    int ActiveTriggers = 0;
    bool Trigger1;
    bool trigger2;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void TriggerRecieve()
    {
        ActiveTriggers++;
        if (ActiveTriggers == TriggersToOpen)
        {
            Debug.Log("Deur is open!!");
            transform.position = new Vector3(transform.position.x, 3f, transform.position.z);
        }
    }

    public void TriggerLeft()
    {
        ActiveTriggers--;
        if (ActiveTriggers == 0)
        {
            Debug.Log("Deur is dicht");
            transform.position = new Vector3(transform.position.x, 1.04f, transform.position.z);
        }
    }
}
