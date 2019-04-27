using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField]
    private GameObject player;
    private Vector3 playerPosition;

    public Vector3 offset;
    public float Min_Y;
    public float Max_Y;

    void Start()
    {
        
    }

    void Update()
    {
        MoveCamera();
    }

    void MoveCamera()
    {
        playerPosition = player.transform.position;
        Vector3 moveToPosition = playerPosition + offset;
        transform.position = new Vector3(
            moveToPosition.x, 
            Mathf.Clamp(moveToPosition.y, Min_Y, Max_Y),
            moveToPosition.z);
    }

}
