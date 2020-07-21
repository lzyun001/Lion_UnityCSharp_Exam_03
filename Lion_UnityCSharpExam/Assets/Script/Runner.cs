using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    public GameObject finish;
    public delegate void Delegaterunner();
    public event Delegaterunner onFinish;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, finish.transform.position, 1 * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.O)) Application.LoadLevel("第三題");
        if (Input.GetKeyDown(KeyCode.P)) Application.LoadLevel("第五題");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Finish") onFinish();
    }
}
