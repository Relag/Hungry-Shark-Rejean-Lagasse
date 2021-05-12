using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance { get; private set; }
    public Text health;
    public Text score;
    public PlayerShark player;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    public void UpdateUI()
    {
        health.text = "Health: " + player.health;
        score.text = "Score: " + player.fishEaten;
    }
}
