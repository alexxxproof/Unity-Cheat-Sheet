using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float speed = 9;

    void Update()
    {
        //Вращение объекта с помощью мыши по горизонтали
        transform.Rotate(0, Input.GetAxis("Mouse X") * speed, 0);
    }
}
