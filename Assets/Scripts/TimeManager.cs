using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI text;
    private float actualHour = 0;
    private float actualMinute = 0;

    private float startTime;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time >= startTime + 15) {
            if(actualMinute >= 60) {
                if(actualHour >= 24) {
                    actualHour = 0;
                    actualMinute = 0;
                } else {
                    actualHour += 1;
                    actualMinute = 0;
                }
            } else {
                actualMinute += 15;
            }
                startTime = Time.time;
                text.text = actualHour + ":" + actualMinute;
        }
        
    }
}
