using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;

  

    //Variable necessery for movement
    public float Speed = 4.5f;
    private Vector2 movement;
    public Animator Animator;

    private int GemCounter;
    private ItemStats Gem;
    //private ItemStats Gem  = new ItemStats("Gem");


    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        GemCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {


        //Moving the player.
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        

        //Set Moving animation.
        Animator.SetFloat("Horizontal", movement.x);
        Animator.SetFloat("Vertical", movement.y);
        Animator.SetFloat("Speed", movement.sqrMagnitude);


        //Set wright Idle animation after stop moving.
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            Animator.SetFloat("LastHorizontal", Input.GetAxisRaw("Horizontal"));
            Animator.SetFloat("LastVertical", Input.GetAxisRaw("Vertical"));
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

   

   
    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.tag == "Gem")
        {

            SoundManager.PlaySound("PickUp");
            GemCounter++;
            Debug.Log("Gems: " + GemCounter);
            Destroy(collision.gameObject);
        }
        else if (collision.tag == "Teleporter" && GemCounter == 3)
        {
            Debug.Log("Win");
            SceneManager.LoadScene(3);
        }
        else if (collision.tag == "Item")
        {
            Destroy(collision.gameObject);
        }
    }



    //private void OnTriggerEnter2D(Collider2D collision)
    //{


    //    if (collision.name == "Gem")
    //    {

    //        SoundManager.PlaySound("PickUp");
    //        GemCounter++;
    //        Debug.Log("Gems: " + GemCounter);
    //        Destroy(collision.gameObject);
    //    }
    //    else if (collision.tag == "Teleporter" && GemCounter == 3)
    //    {
    //        Debug.Log("Win");
    //        SceneManager.LoadScene(3);
    //    }
    //    else if (collision.tag == "Item")
    //    {
    //        Destroy(collision.gameObject);
    //    }
    //}
}
