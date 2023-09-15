using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NEWItem : MonoBehaviour
{
    public float Speed = 4.5f;

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
