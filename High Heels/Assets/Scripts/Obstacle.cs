using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject leftParent;
    public GameObject rightParent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heel")
        {
           
            gameObject.GetComponent<BoxCollider>().enabled = false;

            StartCoroutine(DropHeels());


        }
    }

    IEnumerator DropHeels()
    {
        yield return new WaitForSeconds(0.5f);
        leftParent.transform.GetChild(HeelController.heel).gameObject.SetActive(false);
        rightParent.transform.GetChild(HeelController.heel).gameObject.SetActive(false);
        HeelController.heel--;
        PlayerController.instance.PlayerPosDown();

    }
}
