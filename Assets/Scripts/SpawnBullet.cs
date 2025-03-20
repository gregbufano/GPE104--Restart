using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    public KeyCode Shoot = KeyCode.Space; // Default to Space
    public GameObject Bullet; // Bullet prefab
    public Transform firePoint; // Custom spawn position
    public float bulletForce = 5f; // Bullet speed
    public AudioSource shootAudioSource;

    void Update()
    {
        if (Input.GetKeyDown(Shoot))
        {
            shootAudioSource.Play();
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        if (Bullet != null && firePoint != null)
        {
            // Instantiate the bullet at the firePoint's position & rotation
            GameObject newObject = Instantiate(Bullet, firePoint.position, firePoint.rotation);

            // Apply force if the bullet has a movement script
            BulletMovement newBM = newObject.GetComponent<BulletMovement>();
            if (newBM != null)
            {
                newBM.force = bulletForce;
            }

            // Destroy bullet after 3 seconds
            Destroy(newObject, 3);
        }
        else
        {
            Debug.LogWarning("Bullet prefab or FirePoint is missing!");
        }
    }
}