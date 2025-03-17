using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour

{
    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        // Destroys other object
        Destroy(collider2D.gameObject);
        // Destroys itself
        Destroy(gameObject);
    }
}
