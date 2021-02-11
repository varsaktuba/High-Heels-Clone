using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stick : MonoBehaviour
{
    public GameObject player;
  
  
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Heel")
        {
            PlayerController.instance.GetComponent<Animator>().SetBool("isStreching", true);
            Vector3 playerpos = player.transform.position;
            playerpos.y = -0.3f;
            player.transform.position = playerpos;
        }
    }
}
