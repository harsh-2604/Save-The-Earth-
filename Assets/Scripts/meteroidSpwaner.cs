using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteroidSpwaner : MonoBehaviour
{
    [SerializeField] GameObject[] meteroidPrefab;
    
    public bool Espawn = true;
    public float minX = 0f;
    public float maxX = 0f;
    public static int totalScore = 0;
    public static int highScore = 0;
    void Start()
    {
        totalScore = 0;
        InvokeRepeating("A", 0, 1);
        InvokeRepeating("B", 0, 1.5f);
        InvokeRepeating("C", 0, 1.5f);
        InvokeRepeating("D", 0, 2.5f);
    }

    private void spawner(GameObject gameObject)
    {
        if (!Espawn) return;
        //float randomX = Random.Range(minX, maxX);

        float randomX = Random.Range(-8f, -6.5f);

        switch (Random.Range(0, 3))
        {
            case 1:
                randomX = Random.Range(-3f, 3f);
                break;
            case 2:
                randomX = Random.Range(6.5f, 8f);
                break;
        }


        //float randomY = Random.Range(minY, maxY);

        Vector2 spawnPosition = new Vector2(randomX, transform.position.y);

        Instantiate(gameObject,spawnPosition, Quaternion.identity);
    }

    public void A()
    {
        spawner(meteroidPrefab[0]);
    }


    public void B()
    {
        if (totalScore > 300)
        {
            spawner(meteroidPrefab[1]);
            CancelInvoke("A");
        }
        if (totalScore > 400) InvokeRepeating("A", 0, 0.75f);
    }

    public void C()
    {
        if (totalScore > 600)
        {
            spawner(meteroidPrefab[2]);
            CancelInvoke("A");
            CancelInvoke("B");
        }
        if(totalScore >= 800)
        {
            InvokeRepeating("A", 0, 1);
            InvokeRepeating("B", 0, 2);
        }
    }

    public void D()
    {
        if (totalScore > 1000)
        {
            spawner(meteroidPrefab[3]);
            CancelInvoke("A");
            CancelInvoke("B");
            CancelInvoke("C");
        }
    }
}
