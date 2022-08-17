using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnner : MonoBehaviour
{
    public GameObject enemy;
    public float delay;
    public Transform leftpos;
    public Transform rightpos;
    public Transform midpos;
        



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawn", 0f, delay);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawn()
    {
        int randompos = Random.Range(1, 4);

        if (randompos == 1)
        {
            Instantiate(enemy, leftpos);
        }
        else if (randompos == 2)
        {
            Instantiate(enemy, midpos);
        }
        else
        {
            Instantiate(enemy, rightpos);
        }
    }
}
