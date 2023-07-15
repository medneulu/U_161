using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_items : MonoBehaviour
{
    private int count=0;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("collectible"))
        {
            Debug.Log(count);
            count++;
            Destroy(other.gameObject);
        }
    }

}
