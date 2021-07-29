using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingManager : MonoBehaviour
{
    [SerializeField] private Transform upMark;
    [SerializeField] private Transform downMark;
    [SerializeField] private Transform leftMark;
    [SerializeField] private Transform rightMark;

    [SerializeField] private PointGenerator pointGenerator;

    [SerializeField] private UIManager UIManager;

    public void StartMinigame() {
        pointGenerator.StartGenerator(20);
    }

     public void EndMinigame() {
         UIManager.CloseFishingUI();
    }

    public void Down() {
        RaycastHit2D hit = Physics2D.Raycast(downMark.position, -Vector2.up);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.name == "DOWN(Clone)") {
                Debug.Log("GOOD");
                Destroy(hit.collider.gameObject);
            } else {
                Debug.Log("BAD");
            }
        } else {
            Debug.Log("MISS");
        }
     }

    public void Up() {
        RaycastHit2D hit = Physics2D.Raycast(upMark.position, -Vector2.up);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.name == "UP(Clone)") {
                Debug.Log("GOOD");
                Destroy(hit.collider.gameObject);
            } else {
                Debug.Log("BAD");
            }
        } else {
            Debug.Log("MISS");
        }
    }

    public void Left() {
       RaycastHit2D hit = Physics2D.Raycast(leftMark.position, -Vector2.up);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.name == "LEFT(Clone)") {
                Debug.Log("GOOD");
                Destroy(hit.collider.gameObject);
            } else {
                Debug.Log("BAD");
            }
        } else {
            Debug.Log("MISS");
        }
    }

    public void Right() {
        RaycastHit2D hit = Physics2D.Raycast(rightMark.position, -Vector2.up);
        if (hit.collider != null)
        {
            if (hit.collider.gameObject.name == "RIGHT(Clone)") {
                Debug.Log("GOOD");
                Destroy(hit.collider.gameObject);
            } else {
                Debug.Log("BAD");
            }
        } else {
            Debug.Log("MISS");
        }
    }
}
