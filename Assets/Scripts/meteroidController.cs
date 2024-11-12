using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteroidController : MonoBehaviour
{
    [SerializeField] float downSpeed = 0f;
    [SerializeField] float increasedDownSpeed = 0f;
    [SerializeField] int clicksToDestroy;
    int clickCount;

    private void Update()
    {
        float currentSpeed = downSpeed;

        if (meteroidSpwaner.totalScore > 100 && meteroidSpwaner.totalScore < 300)
        {
            currentSpeed += increasedDownSpeed;
        }

        transform.Translate(0, -currentSpeed * Time.deltaTime, 0);
    }
    public void destroy()
    {
        if (!pauseMenu.isPaused)
        {
            clickCount++;
            if (clickCount == clicksToDestroy)
            {
                Destroy(gameObject);
            }
        }
    }
}
