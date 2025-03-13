using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{
    public GameObject[] display;
    public GameObject chosen;

    public float zOffset = 10;
    public int origin = 0;

    // Start is called before the first frame update
    void Start()
    {
        chosen = display[origin];
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.transform.position = chosen.transform.position + Vector3.back * zOffset;

        if (Input.GetKeyDown(KeyCode.N))
        {
            origin++;
            chosen = display[origin];
            

            


        }

        if (origin == 4)
        {
            origin = 0;
            chosen = display[origin];
        }

    }
}
