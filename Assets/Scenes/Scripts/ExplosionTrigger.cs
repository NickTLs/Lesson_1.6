using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTrigger : MonoBehaviour
{
    public Rigidbody[] Cubes;
    public Transform Epicenter;
    public float ExplosionForce;
    public float ExplosionRadius;

    private void OnTriggerEnter(Collider other)
    {
       if(other.CompareTag("Bomb"))
        {
            foreach (Rigidbody rb in Cubes)
            {
                rb.AddExplosionForce(ExplosionForce, Epicenter.position, ExplosionRadius);
            }
        }
    }
}
