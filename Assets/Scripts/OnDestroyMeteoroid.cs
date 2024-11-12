using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDestroyMeteoroid : MonoBehaviour
{
    [SerializeField] int damage;
    public bool isDamage = false;
    public int score;
    public float sizeAddition;

    private void Update()
    {
        if(transform.position.y < -6.5f) Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Earth"))
        {
            OnDestroyEarth ode = collision.GetComponent<OnDestroyEarth>();
            ode.TakeDamage(damage);
            ode.transform.localScale += Vector3.one * sizeAddition;
            //ode.transform.localScale += new Vector3(transform.localScale.x + sizeAddition, transform.localScale.y + sizeAddition, transform.localScale.z);
            isDamage = true;
            //Debug.Log(OnDestroyEarth.health);
            Destroy(gameObject);
        }
    }
    public void OnDestroy()
    {
        if (!isDamage && transform.position.y > -6.5f)
        {
            meteroidSpwaner.totalScore += score;
            meteroidSpwaner.highScore = meteroidSpwaner.totalScore;
            //Debug.Log(meteroidSpwaner.totalScore);
        }
    }
}
