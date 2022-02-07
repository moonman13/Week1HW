using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public bool CanMove;
    public float MoveConst;
    public float SprintConst;
    public float Drag;

    public SpriteRenderer ren;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove)
        {
            Vector3 pos = transform.position;
            Vector3 pinput;
            pinput.x = Input.GetAxis("Horizontal");
            pinput.y = Input.GetAxis("Vertical");
            pinput.z = 0;
            pinput.Normalize();

            if (pinput.magnitude > 0.1f)
            {
                if(!Input.GetKey(KeyCode.LeftShift))
                {
                    transform.position = pos + pinput * Time.deltaTime * MoveConst;
                }
                else
                {
                    transform.position = pos + pinput * Time.deltaTime * SprintConst;
                }

            }

            if(Input.GetKey(KeyCode.Space))
            {
                ren.color = Random.ColorHSV();
            }
        }


    }
}
