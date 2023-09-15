using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public float LerpSpeed;
    private Transform PlayerTransform;

    // Start is called before the first frame update
    void Start()
    {
        PlayerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3 (PlayerTransform.position.x, PlayerTransform.transform.position.y, transform.position.z) ,LerpSpeed);
    }
}
