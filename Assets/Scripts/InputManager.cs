using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private InputActions playerActionControls;

    [SerializeField] private Player player;
    [SerializeField] private FishingManager fishingControl;

    void Awake()
    {
        playerActionControls = new InputActions();
        PlayerMovement();
    }

    void PlayerMovement() {
        
        playerActionControls.Player.Move.performed += ctx => player.Move(ctx.ReadValue<Vector2>());
        //playerActionControls.Player.Move.canceled += ctx => player.Move(Vector2.zero);
        playerActionControls.Player.Fire.performed += ctx => player.Fire();
    }

    void MinigameInput() {
        //playerActionControls.Minigame.Down.performed += ctx => fishingControl.Down();
        //playerActionControls.Minigame.Left.performed += ctx => fishingControl.Left();
        //playerActionControls.Minigame.Right.performed += ctx => fishingControl.Right();
        //playerActionControls.Minigame.Up.performed += ctx => fishingControl.Up();
    }

    private void OnEnable() {
        playerActionControls.Enable();
    }

    private void OnDisable() {
        playerActionControls.Disable();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
