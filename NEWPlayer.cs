using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWPlayer : MonoBehaviour
{
    public float Speed;
    public Vector3 startPosition;

    [SerializeField]
    private float inputHorizontal;
    [SerializeField]
    private float inputVertical;

    private Vector2 Movement;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        inputVertical = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.E))
        {

            transform.position = new Vector3(7, 0, 0);
        }

        transform.Translate(new Vector3(inputHorizontal, 0, 0) * Speed * Time.fixedDeltaTime);
        transform.Translate(new Vector3(0, inputVertical, 0) * Speed * Time.fixedDeltaTime);

        if (Input.GetKey(KeyCode.F))
        {

            transform.Rotate(new Vector3(0, 0, 7));
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        {
            if (other.tag == "Gem")
            {
                SoundManager.PlaySound("PickUp");
                Destroy(other.gameObject);
            }
            else if (other.tag == "Teleporter")
            {
                Debug.Log("Win");

            }
            else if (other.tag == "Item")
            {
                Destroy(other.gameObject);
            }
        }
    }
}
