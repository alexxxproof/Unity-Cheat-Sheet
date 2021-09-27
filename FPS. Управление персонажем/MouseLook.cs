using UnityEngine;

//Вращение по горизонтали нужно добавлять объекту персонажа, а вращение по вертикали вешать на камеру, которая привязана к объекту персонажа. Это необходимо для правильного воздействия силы гравитации на объект
public class MouseLook : MonoBehaviour
{
    public float speed = 9;

    void Update()
    {
        //Вращение объекта с помощью мыши по горизонтали
        transform.Rotate(0, Input.GetAxis("Mouse X") * speed, 0);
    }
}
