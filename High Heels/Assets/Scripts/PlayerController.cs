using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float speed;
    Animator anim;
    public GameObject player;
   
    private Rigidbody _rb;
   

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow) || MobileInput.Instance.swipeLeft)
        {

            anim.SetBool("isWalking", true);
            _rb.velocity =Vector3.left * speed * Time.deltaTime; //Vector3.left = new Vector3(-1,0,0)

        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) || MobileInput.Instance.swipeRight)
        {

            anim.SetBool("isWalking", true);
            _rb.velocity = Vector3.right * speed * Time.deltaTime; //Vector3.left = new Vector3(1,0,0)

        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) || MobileInput.Instance.swipeUp)
        {

            anim.SetBool("isWalking", true);
            _rb.velocity = Vector3.forward * speed * Time.deltaTime; //Vector3.forward = new Vector3(0,0,1)

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) || MobileInput.Instance.swipeDown )
        {

            anim.SetBool("isWalking", true);
            _rb.velocity = -Vector3.forward * speed * Time.deltaTime; //-Vector3.forward = new Vector3(0,0,-1)

        }
      
      

    }
    public void PlayerPosUp()
    {
        Vector3 playerpos = transform.localPosition;
        playerpos.y += 0.5f;
        transform.localPosition = playerpos;
    }
    public void PlayerPosDown()
    {
        Vector3 playerpos = transform.localPosition;
        playerpos.y -= 0.5f;
        transform.localPosition = playerpos;

    }
    public void Finish()
    {
      
        _rb.velocity = Vector3.zero;
        anim.SetBool("isDancing", true);
        player.transform.Rotate(0, 180, 0);
       
    }

 
    



}
