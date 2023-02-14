using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    [SerializeField] float startTime;

    float currentTime;
    bool timerStarted = false;

    [SerializeField] TMP_Text timerText;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
        timerText.text = "Time Left:" + currentTime.ToString("f1");
        timerStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0)
            {
                timerStarted = false;
                currentTime = 0;
            }
            timerText.text = "Time Left:" + currentTime.ToString("f1");
        }
    }
}
