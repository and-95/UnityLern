using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMove : MonoBehaviour
{

    [SerializeField]
    private float _speed; // Скорость движения, а в дальнейшем ускорение

    [SerializeField]
    private float _turnSpeed;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) // движение влево
        {
            
            transform.position += transform.right * -_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.D)) // движение вправо
        {

            transform.position += transform.right * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.W)) // движение вперед
        {

            transform.position += transform.forward * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.S)) // движение назад
        {

            transform.position += transform.forward * -_speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.LeftArrow)) // поворот влево
        {

            transform.Rotate(Vector3.up, -_turnSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)) // поворот вправо
        {

            transform.Rotate(Vector3.up, _turnSpeed * Time.deltaTime);
        }
    }


}
