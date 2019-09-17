using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    CharacterController cmpCC;


    // Start is called before the first frame update
    void Start()
    {
        cmpCC = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        cmpCC.Move(transform.forward * 10 * Time.deltaTime);
    }
}
