using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _enemy;
    [SerializeField]
    private Transform _spawn;
   
    public Transform _Player;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_enemy, _spawn.position, _spawn.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
