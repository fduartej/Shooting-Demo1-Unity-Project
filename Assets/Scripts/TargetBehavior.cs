using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehavior : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
         gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnMouseDown() {
        gameManager.IncrementScore();
        Destroy(gameObject);
    }

}
