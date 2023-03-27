using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class guy : MonoBehaviour
{
    [SerializeField]
    float _speed;

    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.position += new Vector3(horizontal, 0, vertical) * Time.deltaTime * _speed;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);
        Vector3 lookpos = new Vector3(hit.point.x, transform.position.y, hit.point.z);
        transform.LookAt(lookpos);
    }

    private void Update()
    {



    }
}


