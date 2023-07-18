using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movement : MonoBehaviour
{
    public Transform PosA, PosB;
    public int Speed;
    Vector2 targetPos; 
    void Start()
    {
        targetPos = PosB.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, PosA.position) < 1f) targetPos = PosB.position;
        else if (Vector2.Distance(transform.position, PosB.position) < 1f) targetPos = PosA.position;

        transform.position = Vector2.MoveTowards(transform.position,targetPos,Speed*Time.deltaTime);
    }
}


