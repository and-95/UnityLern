using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    [SerializeField]
    private GameObject _cube;

    [SerializeField]
    private Transform _spawnPoint;

    [SerializeField]
    private GameObject _instanceCube;


    // Start is called before the first frame update
    void Start()
    {
        _instanceCube =  Instantiate(_cube, _spawnPoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
            print("Right Arrow pressed");

        if (Input.GetKey(KeyCode.D))
            print("D pressed");

        if (Input.GetKeyDown(KeyCode.RightArrow))
            print("Right Arrow was pressed");

        if (Input.GetKey(KeyCode.D))
            print("D pressed");
    }
   
}
