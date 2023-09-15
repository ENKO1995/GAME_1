using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public GameObject TextDisplay;
    public int SecondsLeft = 180;
    public bool TakingAway = false;

    private void Start()
    {
        TextDisplay.GetComponent<Text>().text =  "" + SecondsLeft;
    }
    private void Update()
    {
        if (TakingAway == false && SecondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }
        if (TakingAway == false && SecondsLeft <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    IEnumerator TimerTake()
    {
        TakingAway = true;
        yield return new WaitForSeconds(1);
        SecondsLeft -= 1;
        TextDisplay.GetComponent<Text>().text = "" + SecondsLeft;
        TakingAway = false;
    }

    
}
