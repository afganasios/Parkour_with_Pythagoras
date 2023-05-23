using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinSpin : MonoBehaviour
{
    private bool isUp = false;

    private Vector3 upPos;
    private Vector3 downPos;
    // Start is called before the first frame update
    void Start()
    {
        upPos = transform.position + new Vector3(0, 0.25f, 0);
        downPos = transform.position + new Vector3(0, -0.25f, 0);

        //var t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0.7f, 0f);
        //transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);

        if (!isUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, upPos, 0.6f * Time.deltaTime);
        }
        if (transform.position == upPos)
        {
            isUp = true;
        }

        if (isUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, downPos, 0.6f * Time.deltaTime);
        }
        if (transform.position == downPos)
        {
            isUp = false;
        }
    }
}

