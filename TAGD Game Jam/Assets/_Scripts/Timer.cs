﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float duration;
    public Image fillImage;

    public void Start()
    {
        fillImage.fillAmount = 1f;
    }

    public void Update()
    {
        if (((int)Time.time - 1) % duration == 0)
        {
            fillImage.fillAmount = 1f;
            StartCoroutine(timer(duration));
        }
        //Debug.Log(Time.time);
    }

    public IEnumerator timer(float duration)
    {
        float startTime = Time.time;
        float time = duration;
        float value = 0;

        while ((Time.time - startTime) < duration)
        {
            time -= Time.deltaTime;
            value = time / duration;
            fillImage.fillAmount = value;
            yield return null;
        }
        // Event happens here(basically send out unity event of attack happening then have a listener listen for it,
        // such as the enemy)

    }
}