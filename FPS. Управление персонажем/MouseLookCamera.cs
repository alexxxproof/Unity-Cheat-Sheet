using UnityEngine;

//Вращение по горизонтали нужно добавлять объекту персонажа, а вращение по вертикали вешать на камеру, которая привязана к объекту персонажа.
//Это необходимо для правильного воздействия силы гравитации на персонажа
public class MouseLookCamera : MonoBehaviour
{
    public float speed = 9;
    public float min = -45;
    public float max = 45;

    float _rotationX = 0;

    void Update()
    {
        //Получает данные, вводимые с помощью мыши
        _rotationX -= Input.GetAxis("Mouse Y") * speed;
        //Ограничивает значение между минимальным и максимальным
        _rotationX = Mathf.Clamp(_rotationX, min, max);

        float rotationY = transform.localEulerAngles.y;
        transform.localEulerAngles = new Vector3(_rotationX, rotationY, 0);
    }
}
