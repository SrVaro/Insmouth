using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine;
using System;

public class Player : MonoBehaviour
{

    public float speed = 10;
    private Vector2 move;
    private LineRenderer lineRenderer;
    public GameObject fishingRod;
    public FishingManager fishingScript;
    [SerializeField] private UIManager UIManager;

    private void Awake() {
        fishinRodSetup();
    }

    private void fishinRodSetup() {
        lineRenderer = gameObject.AddComponent<LineRenderer>() as LineRenderer;
        lineRenderer.startWidth = 0.1f;
        lineRenderer.endWidth = 0.1f;
        lineRenderer.enabled = false;
        lineRenderer.sortingLayerName = "UI";
        fishingRod.SetActive(false);
    }

    public void Move(Vector3 movement){
        move = new Vector3(movement.x * speed, movement.y * speed) * Time.deltaTime;

        lineRenderer.SetPosition(0, transform.position);
        lineRenderer.SetPosition(1, fishingRod.transform.position);
    }

    public void Fire() {
        Debug.Log("FIRE!");
        StartFishing();
    }

    void Update() {
        transform.Translate(move, Space.World);
    }

    void StartFishing(){
        //playerActionControls.Player.Move.Disable();
        fishingRod.transform.position = transform.position + new Vector3(0, 6, 0);
        fishingRod.SetActive(true);
        lineRenderer.enabled = true;
        UIManager.OpenFishingUI();
        fishingScript.StartMinigame();
    }
}
