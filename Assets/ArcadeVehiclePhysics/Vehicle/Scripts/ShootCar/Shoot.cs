using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
  public int damge = 1;
  // public int playerHeath = 10;

  // public int currentHealth;

  public float fireTime = 0.3f;
  private float lastFireTime = 0;

  public GameObject somke;
  public GameObject flare;
  public GameObject GunHead;
  // public HealthBar healthBar;

  // Start is called before the first frame update
  void Start()
  {
    lastFireTime = Time.time;
    // currentHealth = playerHeath;

    // if (healthBar != null) {
    //   healthBar.SetMaxHealth(playerHeath);
    // }
    
  }

  // Update is called once per frame
  void Update()
  {

  }

  public void Fire(string player)
  {

    if (Time.time > lastFireTime + fireTime)
    {
      RaycastHit hit;

      if (Physics.Raycast(GunHead.transform.position, GunHead.transform.forward, out hit))
      {
        // Tao hieu ung khoi
        GameObject sm = Instantiate(somke, GunHead.transform.position, GunHead.transform.rotation) as GameObject;
        Destroy(sm, 0.2f);

        // Tao hieu ung choe lua
        GameObject fla = Instantiate(flare, hit.transform.position, hit.transform.rotation) as GameObject;
        Destroy(fla, 0.2f);

        Debug.Log(hit.transform.position);
        if (hit.transform.tag.Equals("Player"))
        {
          Debug.Log("********************************");
          hit.transform.gameObject.GetComponent<PlayerController>().TakeDamage(player, damge);
        }
      }

      lastFireTime = Time.time;
    }

  }
}
