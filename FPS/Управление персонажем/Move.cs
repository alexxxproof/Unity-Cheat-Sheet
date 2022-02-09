using UnityEngine;

//Требует предварительного подключения компонента
[RequireComponent(typeof(CharacterController))]
public class Move : MonoBehaviour
{
    public float speed = 3;
    public float gravity = -9.8f;

    CharacterController _char;

    void Start()
    {
        _char = GetComponent<CharacterController>();

        //Скрывает указатель мыши в центре экрана. Показать его можно клавишей Esc
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        //"Horizontal" и "Vertical" — это дополнительные имена для сопоставления с клавиатурой
        float deltaX = Input.GetAxis("Horizontal") * speed;
        float deltaZ = Input.GetAxis("Vertical") * speed;

        var move = new Vector3(deltaX, 0, deltaZ);
        //Ограничивает модуль вектора скоростью движения, чтобы движение по диагонали не происходило быстрее движения вдоль координатных осей
        move = Vector3.ClampMagnitude(move, speed);
        //На игрока действует постоянная сила, тянущая его вниз.
        //Чтобы его тянуло всегда вниз в глобальном пространстве, нужно его ограничить горизонтальным вращением,
        //а привязанную к нему камеру ограничить вертикальным вращением
        move.y = gravity;
        //Это время между кадрами. Умножение скорости на эту переменную приведет к одинаковой скорости на всех устройствах
        move *= Time.deltaTime;
        //Преобразование от локальных к глобальным координатам
        move = transform.TransformDirection(move);
        //Перемещение объекта со связанным компонентом CharacterController. Методу следует передавать вектор, определенный в глобальном пространстве
        _char.Move(move);
    }
}
