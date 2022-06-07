using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] bool delta;
    private void Update()
    {
        if (delta)
        {

        transform.eulerAngles += Vector3.up * Time.deltaTime * speed;
        }
        else
        {

        transform.eulerAngles += Vector3.up  * speed;
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            Time.timeScale = 0;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Time.timeScale = 1;
        }

    }


}
