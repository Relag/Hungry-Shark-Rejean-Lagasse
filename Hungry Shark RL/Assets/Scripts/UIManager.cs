using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }
    public Text health;
    public Text score;
    public Text gameOver;
    public PlayerShark player;
    public Button restartButton;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    //Set UI elements upon player collision
    public void UpdateUI()
    {
        health.text = "Health: " + player.health;
        score.text = "Score: " + player.fishEaten;
        if (player.health <= 0)
            GameOver();
    }

    public void GameOver() {
        gameOver.text = "You ate too many poison fish. You now have a tummy ache. You ate " + player.fishEaten + " fish.";
        restartButton.gameObject.SetActive(true);
    }
}
