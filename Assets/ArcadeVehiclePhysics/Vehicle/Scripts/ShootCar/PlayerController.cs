using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerHeath = 10;

    public HealthBar healthBar;
    public int currentHealth;

    private GameObject gameController;

    public void TakeDamage(string player, int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            // Destroy
            Debug.Log("Destroy Destroy Destroy Destroy Destroy");
            Destroy(transform.parent.gameObject);

            gameController.GetComponent<GameController>().EndGame(player);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        if (gameController == null) {
            gameController = GameObject.FindGameObjectWithTag("GameController");
        }

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
