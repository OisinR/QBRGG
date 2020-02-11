using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    float rotationSpeed = 30;


    void Update()
    {
        //Vector3 desiredPosition = target.position + offset;
        
        //Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        //transform.position = smoothedPosition;
        


        //transform.LookAt(target);
        //transform.Rotate(0,90,0);
        transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X")* 2323 * Time.deltaTime);
    }

}