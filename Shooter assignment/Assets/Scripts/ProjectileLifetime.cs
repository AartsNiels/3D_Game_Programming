using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifetime : MonoBehaviour {
    float timer = 0;
    float lifeTime = 3f;
    
    // Update is called once per frame
    void Update()
    {
        if (timer < lifeTime)
            timer += Time.deltaTime;
        else
        {
            //after 3 seconds destroy this gameobject
            Destroy(gameObject);
        }
    }
}