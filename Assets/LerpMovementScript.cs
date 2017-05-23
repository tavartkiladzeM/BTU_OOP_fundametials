using UnityEngine;

public class LerpMovementScript : MonoBehaviour
{
    public float start = 0f;
    public float end = 10f;
    public float step = 0.1f;

    public Transform target;

    void Update ()
    {
        LerpMove();
        LerpRotate();
    }

    void LerpMove()
    {
        start = Mathf.Lerp(start, end, step);
        transform.position = Vector3.left * start;
    }

    void LerpRotate()
    {
        transform.rotation = Quaternion.Lerp(transform.rotation, target.rotation, step);
    }
} 
