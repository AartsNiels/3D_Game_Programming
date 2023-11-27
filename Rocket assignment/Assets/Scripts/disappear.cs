using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disappear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
            col.GetComponent<RocketController>().points++;
            Destroy(gameObject);
            //col.gameObject.SetActive(false);
    }
}