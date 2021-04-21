using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public int damge = 1;
    public float playerHeath = 10;


    public float fireTime = 0.3f;
    private float lastFireTime = 0;

    public GameObject somke;
    public GameObject flare;
    public GameObject GunHead;

    // Start is called before the first frame update
    void Start()
    {
        lastFireTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        // Khi nhan chuot trai de ban
        if (Input.GetMouseButton(0))
        {
            Fire();
        }
    }

    void Fire()
    {

        if (Time.time > lastFireTime + fireTime)
        {
            RaycastHit hit;

            if (Physics.Raycast(GunHead.transform.position, GunHead.transform.forward, out hit))
            {
                // Tao hieu ung khoi
                GameObject sm = Instantiate(somke, GunHead.transform.position, GunHead.transform.rotation) as GameObject;
                Destroy(sm, 0.5f);

                // Tao hieu ung choe lua
                GameObject fla = Instantiate(flare, hit.transform.position, hit.transform.rotation) as GameObject;
                Destroy(fla, 0.5f);

                Debug.Log(hit.transform.tag);
                if (hit.transform.tag.Equals("Player"))
                {
                    Debug.Log("********************************");
                    // hit.transform.gameObject.GetComponent<ZombieController>().Shoot(damge);
                }
            }

            lastFireTime = Time.time;
        }

    }

}
