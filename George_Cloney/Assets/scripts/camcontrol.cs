using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camcontrol : MonoBehaviour
{
    [SerializeField]
    Transform _guy;





    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_guy == null)
        {
            return;
        }
        Vector3 playerPos = new Vector3(_guy.position.x, transform.position.y, _guy.position.z);
        Vector3 newPosition = Vector3.Lerp(transform.position, playerPos, Time.deltaTime * Vector3.Distance(transform.position, playerPos));
        transform.position = newPosition;
    }
}
