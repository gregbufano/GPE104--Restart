using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   public KeyCode shoot;
   public GameObject Bullet;

    // Update is called once per frame
    void Update()
    {
        Transform tf = transform;

        if (Input.GetKeyDown(shoot))
        {
            Vector3 spawnPosition = transform.position+transform.up * 2f;

            Instantiate(Bullet, spawnPosition, transform.rotation);
        }
    }
}
