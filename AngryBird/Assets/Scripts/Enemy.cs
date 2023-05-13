using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Target)
    {
        if(Target.collider.GetComponent<Bird>())
        {
            Destroy(gameObject);
        }
        else if (Target.contacts[0].normal.y<0.5)
        {
            Destroy(gameObject);
        }
    }
}
