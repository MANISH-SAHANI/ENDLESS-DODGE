using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text scoretext;
    public GameObject GameOverPanel;
    bool game = false;
    int score = 0;

    private void Awake()
    {
        GameOverPanel.SetActive(false);
    }
    public void gameOver()
    {
        game = true;
        FindObjectOfType<ObjectSpawn>().CancelInvoke();
        GameOverPanel.SetActive(true);
    }

    public void scoreIncrease()
    {
        if(!game)
        {
            score++;
            scoretext.text = score.ToString();
        }
    }
    
    public void Restart()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
