using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishManager : MonoBehaviour
{

    public static FishManager instance;
    public List<Fish> pooledFish;
    
    //The world positions at the edge of the screen
    private int top = 5;
    private int bottom = -3;
    private int left = -5;
    private int right = 6;

    //Timers for fish
    private float fishTimer;
    private float poisonFishTimer;
    private float healthTimer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Check if each fish is enabled. If not, check time lapsed since disable.
    void Update()
    {
        foreach (Fish fish in pooledFish) {
            if (!fish.isActiveAndEnabled && fish.gameObject.CompareTag("Health")) {
                healthTimer += Time.deltaTime;
                if (healthTimer >= fish.spawnRate) {
                    EnableFish(fish);
                    healthTimer = 0f;
                }
            }
            else if (!fish.isActiveAndEnabled && fish.gameObject.CompareTag("Fish")) {
                fishTimer += Time.deltaTime;
                if (fishTimer >= fish.spawnRate) {
                    EnableFish(fish);
                    fishTimer = 0f;
                }
            }
            else if (!fish.isActiveAndEnabled && fish.gameObject.CompareTag("PoisonFish")) {
                poisonFishTimer += Time.deltaTime;
                if (poisonFishTimer >= fish.spawnRate) {
                    EnableFish(fish);
                    poisonFishTimer = 0f;
                }
            }   
        }
    }

    void EnableFish(Fish fish) {
        fish.timeSinceAppeared = 0f;
        fish.transform.position = new Vector2(Random.Range(left, right), Random.Range(bottom, top));
        fish.gameObject.SetActive(true);
        //TODO: Ensure fish do not spawn on top of each other.
    }
}
