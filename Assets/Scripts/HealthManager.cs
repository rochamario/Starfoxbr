using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public float maxHealth = 10.0f;
    private float currentHealth;

    // Use this for initialization
    void Start()
    {
        currentHealth = maxHealth;
    }

    void DamagePlayer(float damageAmount)
    {
        if(damageAmount < 0)
        {
            Debug.Log("Vc não pode passar um valor negativo para dano");
            return;
        }

        currentHealth -= damageAmount;

        if (currentHealth < 0)
        {
            //Derrota
        }
    }

    void RestoreHealth(float healthAmount)
    {
        if (healthAmount < 0)
        {
            Debug.Log("Vc não pode passar um valor negativo para vida");
            return;
        }

        currentHealth += healthAmount;

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
