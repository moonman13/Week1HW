using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    public bool CamCanMove;

    public float CamMoveSens;
    public float CamMoveDecay;


    public float CamScrollSens;
    public float CamScrollDecay;

    public GameObject player;

    public Vector3 CamOffset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + CamOffset;
        if(CamCanMove)
        {
            Vector3 cinput;
            Vector3 pos = transform.position;
            Vector2 scroll;

            cinput.x = Input.GetAxis("Horizontal");
            cinput.y = Input.GetAxis("Vertical");
            scroll = Input.mouseScrollDelta;
            cinput.z = 0;
            
            if (cinput.magnitude > 0.1f)
            {
                transform.position += cinput * Time.deltaTime * CamMoveSens;
              
            }

            if(Mathf.Abs(scroll.y) > 0.1f)
            {
                Camera.main.orthographicSize += scroll.y * Time.deltaTime * CamScrollSens;
            }
        }
    }
}
