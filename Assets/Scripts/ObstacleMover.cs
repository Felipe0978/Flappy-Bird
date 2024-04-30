using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Get GameManager
        var gameManager = GameManager.Instance;

        if(gameManager.IsGameOver()) {
            return;
        }

        // Move Object
        float x = gameManager.obstacleSpeed * Time.fixedDeltaTime;
        transform.position -= new Vector3(x, 0, 0);

        if(transform.position.x <= -gameManager.obstacleOffsetX) {
            Destroy(gameObject);
        }
        
    }
}
