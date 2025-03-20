using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    public AudioSource blowUpAudioSource;
    
   
    // Start is called before the first frame update
    public virtual void Start()
    {
        
    }

    // Update is called once per frame
    public virtual void Update()
    {
        
    }

    public virtual void Die()
    {
        blowUpAudioSource.Play();
        print("GameObject Destroyed");
        
        Destroy(gameObject);
    }
}
