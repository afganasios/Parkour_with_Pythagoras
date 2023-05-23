using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public GameObject player;
    public Vector3 resetPosition;
    public GameObject resetPos;
    Transform resetT;

    //private Transform pt;

    // Start is called before the first frame update
    void Start()
    {
        //pt = player.GetComponent<Transform>;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.position.y < 0.1f)
        {
            player.transform.position = resetPosition;
        }
    }
}
