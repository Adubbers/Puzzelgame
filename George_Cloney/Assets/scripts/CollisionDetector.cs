using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{



    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the DestroyOnCollision script attached
        DestroyOnCollision destroyOnCollision = collision.gameObject.GetComponent<DestroyOnCollision>();

        // If the collided object has the script attached, destroy it
        if (destroyOnCollision != null)
        {
            destroyOnCollision.DestroyObject();
        }
    }

}
