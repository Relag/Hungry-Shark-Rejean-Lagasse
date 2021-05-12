using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFish : Fish
{
    

    // Start is called before the first frame update
    void Start()
    {
        timeTilLeave = 5.0f;
        spawnRate = 1f;
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();
    }
}
