using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ItemDataBase : MonoBehaviour
{
    private GameObject LALA;
    //public ItemStats[] items;
    [SerializeField]
    public ItemStats itemOne;
    public ItemStats itemTwo;

    
    private void Start()
    {
        
    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {

//        if (collision.name == "Gem")
//        {
//            SoundManager.PlaySound("PickUp");
//            GemCounter++;
//            Debug.Log("Gems: " + GemCounter);

//}
//        else if (collision.tag == "Teleporter" && GemCounter == 3)
//        {
//            Debug.Log("Win");
//            SceneManager.LoadScene(3);
//        }
//        else if (collision.tag == "Item")
//        {
//            Destroy(collision.gameObject);
//        }
//    }
}
