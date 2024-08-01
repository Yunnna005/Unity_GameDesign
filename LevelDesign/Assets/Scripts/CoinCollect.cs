using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinCollect : MonoBehaviour
{
    public static int numCoinsRemaining = 0;

    private void Start()
    {
        numCoinsRemaining++;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;

        numCoinsRemaining--;
        gameObject.SetActive(false);

        if(numCoinsRemaining <= 0)
        {
            // Win Condition
            SceneManager.LoadScene("scene_Complited");
        }
    }
}
