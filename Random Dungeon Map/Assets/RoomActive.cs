using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomActive : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="odac�k")
        {
            print("sfdghjk�l�lkjhgfhjkl");
            Odac�k odac�k = other.gameObject.GetComponent<Odac�k>();
            odac�k.enabled= true;
        }
    }
}
