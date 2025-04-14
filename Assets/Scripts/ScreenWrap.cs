using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public class ScreenWrap : MonoBehaviour
{
    
    private Rigidbody2D myRigidbody;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // get the screen position of object in Pixels
        Vector3 screenPos =  Camera.main.WorldToScreenPoint(transform.position);

// Get the right side of the screen in world units
        float rightSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x;
        float leftSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).x;
       

       float topOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y;
       float bottomOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y;

       // if player is moving through left side of screen
       if (screenPos.x <= 0 && myRigidbody.linearVelocity.x < 0)
       {
        transform.position = new Vector2(rightSideOfScreenInWorld, transform.position.y);
       }
    }
}

