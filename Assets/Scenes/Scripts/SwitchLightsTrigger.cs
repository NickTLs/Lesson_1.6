using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLightsTrigger : MonoBehaviour
{
    public GameObject LightFirst;
    public GameObject LightSecond;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bomb"))
        {
            LightFirst.SetActive(false);
            LightSecond.SetActive(true);
        }

    }

}
