using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerHeath = 10;

    public HealthBar healthBar;
    public int currentHealth;

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            // Destroy
            Debug.Log("Destroy Destroy Destroy Destroy Destroy");
            Destroy(transform.parent.gameObject);
            Time.timeScale = 0;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = playerHeath;

        if (healthBar != null)
        {
            healthBar.SetMaxHealth(playerHeath);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
