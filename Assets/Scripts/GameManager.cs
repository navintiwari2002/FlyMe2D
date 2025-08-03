using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float timer = 0f;

    private void Update()
    {
        if (timer <= 0f)
        {
            GameObject gm = Instantiate(
                obstaclePrefab, 
                new Vector3(5f, Random.Range(-3f, 0f), 0f),
                Quaternion.identity
            );
            Destroy(gm, 5f);
             
            timer = 2f;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
