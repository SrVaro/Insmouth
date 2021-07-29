using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    [SerializeField] private GameObject fishingUI;

    public void OpenFishingUI() {
        fishingUI.SetActive(true);
    }

    public void CloseFishingUI() {
        fishingUI.SetActive(false);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
