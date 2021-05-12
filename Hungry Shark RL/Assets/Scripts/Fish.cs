using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : MonoBehaviour
{
    public float spawnRate;
    public float timeSinceAppeared;
    public float timeTilLeave;

    // Start is called before the first frame update
    void Start()
    {
        timeSinceAppeared = 0f; 
    }

    // Update is called once per frame
    protected void Update()
    {
        timeSinceAppeared += Time.deltaTime;

        if (timeSinceAppeared > timeTilLeave) {
            gameObject.SetActive(false);
        }
    }
}
