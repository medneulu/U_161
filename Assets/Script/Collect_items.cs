using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_items : MonoBehaviour
{
    private int count=0;
    [SerializeField] private AudioClip clickSound;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("collectible"))
        {
            Debug.Log(count);
            count++;
            AudioSource.PlayClipAtPoint(clickSound,other.transform.position);
            Destroy(other.gameObject);
        }
    }

}
