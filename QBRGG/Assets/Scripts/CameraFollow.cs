using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target, t2;

    public float smoothSpeed = 0.4f;
    public Vector3 offset;
    float rotationSpeed = 30;
    public bool player1 = true;

    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, target.position, smoothSpeed);
        



        transform.LookAt(t2);
        //transform.Rotate(0,90,0);
        /*
        if (player1)
        {
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse XP1") * 2323 * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse XP2") * 2323 * Time.deltaTime);
        }*/
    }

}