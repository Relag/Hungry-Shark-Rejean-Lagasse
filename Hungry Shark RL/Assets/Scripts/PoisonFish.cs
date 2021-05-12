using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonFish : Fish
{
    // Start is called before the first frame update
    void Start()
    {
        timeTilLeave = 6.0f;
        spawnRate = 4f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
