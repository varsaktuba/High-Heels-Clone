using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public GameObject player;
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heel")
        {
            PlayerController.instance.GetComponent<Animator>().SetBool("isStreching", false);
            
            Vector3 playerpos = player.transform.position;
            playerpos.y = 2f;
            player.transform.position = playerpos;
        }
    }
}
