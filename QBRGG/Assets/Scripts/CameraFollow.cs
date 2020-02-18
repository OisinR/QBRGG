using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    float rotationSpeed = 30;
    public bool player1 = true;

    void Update()
    {
        //Vector3 desiredPosition = target.position + offset;

        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //transform.position = smoothedPosition;



        //transform.LookAt(target);
        //transform.Rotate(0,90,0);
        if (player1)
        {
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse XP1") * 2323 * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse XP2") * 2323 * Time.deltaTime);
        }
    }

}