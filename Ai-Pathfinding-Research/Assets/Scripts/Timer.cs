using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timeText;
    public bool isTiming;

    private float time;

    // Update is called once per frame
    void Update()
    {
        if (isTiming)
        {
            time += Time.deltaTime;
            timeText.text = time.ToString("000.00");
        }
    }
}
