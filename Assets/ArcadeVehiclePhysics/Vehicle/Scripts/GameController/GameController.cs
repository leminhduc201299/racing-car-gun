using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject menu;
    public Text winner;

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void EndGame(string player)
    {
        winner.text = player + " Win";
        Time.timeScale = 0;
        menu.SetActive(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        menu.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
