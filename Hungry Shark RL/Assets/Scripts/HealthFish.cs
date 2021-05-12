using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthFish : Fish
{
    // Start is called before the first frame update
    void Start()
    {
        timeTilLeave = 3.0f;
        spawnRate = 15f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
