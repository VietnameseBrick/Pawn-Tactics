using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
    PlayerMovement basicMovementScript;
    public float speedBoost = 5f;

    // Start is called before the first frame update
    void Start()
    {
        basicMovementScript = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
            basicMovementScript.moveSpeed += speedBoost;
        else if (Input.GetKeyUp(KeyCode.LeftShift))
            basicMovementScript.moveSpeed -= speedBoost;
        
    }
}
