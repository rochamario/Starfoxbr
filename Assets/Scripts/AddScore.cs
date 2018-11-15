using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public int pointValue = 100;

    private void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Player")
        {
            ScoreManager.Instance.score += pointValue;
        }
        

    }

}
