using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPlatform : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" || other.gameObject.tag == "Heel")
        {
            GameManager.instance.Win();
        }
    }
}
