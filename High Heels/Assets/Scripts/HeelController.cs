using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeelController : MonoBehaviour
{
    public GameObject leftParent;
    public GameObject rightParent;
    public static int heel = 1;
    
  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Heel")
        {
          

            leftParent.transform.GetChild(heel).gameObject.SetActive(true);
            rightParent.transform.GetChild(heel).gameObject.SetActive(true);
            Destroy(other.gameObject);
            PlayerController.instance.PlayerPosUp();
            heel++;
           
          
           

        }
      
      

    }
   
}
