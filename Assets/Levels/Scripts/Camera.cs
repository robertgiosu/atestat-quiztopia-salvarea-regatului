using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] private float speed;
    private float pozX;
    private Vector3 viteza = Vector3.zero;
    [SerializeField] private Transform player;
    [SerializeField] private float AheadDistance;
    [SerializeField] private float CameraSpeed;
    private float LookAhead;
    void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(pozX, transform.position.y, transform.position.z), ref viteza, speed * Time.deltaTime);
        transform.position = new Vector3(player.position.x + LookAhead,transform.position.y,transform.position.z);
        LookAhead = Mathf.Lerp(LookAhead, (AheadDistance * player.localScale.x), Time.deltaTime * CameraSpeed);
    }
}
