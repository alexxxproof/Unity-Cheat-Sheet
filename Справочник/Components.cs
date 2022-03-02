using UnityEngine;

public class Move : MonoBehaviour
{
    Component c;

    void Start()
    {
        //Определяет местоположение объекта в пространстве
        c = transform;
        //Определяет форму объекта
        c = GetComponent<MeshFilter>();
        //Отрисовывает объект на сцене
        c = GetComponent<MeshRenderer>();
        //Отвечает за столкновения
        c = GetComponent<Collider>();
        //Придает объекту физические свойства
        var rb = GetComponent<Rigidbody>();
        var rbd = rb.drag;          //сопротивление воздуха при движении
        var rbad = rb.angularDrag;  //сопротивление воздуха при вращении
        var rbk = rb.isKinematic;   //не действуют столкновения 
    }
}
