using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointGenerator : MonoBehaviour
{
    [SerializeField] private GameObject up;
    [SerializeField] private GameObject down;
    [SerializeField] private GameObject left;
    [SerializeField] private GameObject right;

    [SerializeField] private Transform upGenerator;
    [SerializeField] private Transform downGenerator;
    [SerializeField] private Transform leftGenerator;
    [SerializeField] private Transform rightGenerator;

    [SerializeField] private FishingManager fishingControl;


    private bool generatorRunning = false;
    private int gameDuration = 20;

    public void StartGenerator(int time) {
        gameDuration = time;
        StartCoroutine("Timer");
    }

    IEnumerator Timer() 
    {
        for (int i = 0; i < gameDuration; i++)
        {
            int rng = (int) Random.Range(1f, 8f);
            if(rng >= 1 && rng <= 2)        Instantiate(up, upGenerator.position, Quaternion.identity);
            else if (rng > 2 && rng <= 4)   Instantiate(down, downGenerator.position, Quaternion.identity);
            else if (rng > 4 && rng <= 6)   Instantiate(left, leftGenerator.position, Quaternion.identity);
            else if (rng > 6 && rng <= 8)   Instantiate(right, rightGenerator.position, Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }

        fishingControl.EndMinigame();
    }
}
