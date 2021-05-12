using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoodFish : Fish
{
    

    // Start is called before the first frame update
    void Start()
    {
        timeTilLeave = 3.0f;
    }

    // Update is called once per frame
    void Update()
    {
        base.Update();
    }
}
