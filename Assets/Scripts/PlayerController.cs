using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private float speedPlayer;
    [SerializeField] private float speedToRotate = 1;
    private bool isCamera1 = true;
    private bool isCamera2 = false;
    private bool isCamera3 = false;
    private bool resetpos = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ControllerPlayer();
        
    }

    private void ControllerPlayer()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            isCamera1 = true;
            isCamera2 = false;
            isCamera3 = false;
            resetpos = true;
        }
        else if(Input.GetKeyDown(KeyCode.F2))
        {
            isCamera1 = false;
            isCamera2 = true;
            isCamera3 = false;
            resetpos = true;
        }
        else if(Input.GetKeyDown(KeyCode.F3))
        {
            isCamera1 = false;
            isCamera2 = false;
            isCamera3 = true;
            resetpos = true;
        }

        float axisHorizontal = Input.GetAxisRaw("Horizontal");
        if (isCamera1)
        {
            if (resetpos)
            {
                player.transform.localRotation = Quaternion.AngleAxis(90, Vector3.up);
                resetpos = false;
            }
            MovePlayerX2D(axisHorizontal);
        } 
        else if (isCamera2)
        {
            if (resetpos)
            {
                player.transform.localRotation = Quaternion.AngleAxis(90, Vector3.up);
                resetpos = false;
            }
            MovePlayerZ2D(axisHorizontal); 
        }
        else if (isCamera3)
        {
            if (resetpos)
            {
                player.transform.localRotation = Quaternion.AngleAxis(90, Vector3.up);
                transform.localRotation = Quaternion.AngleAxis(0, Vector3.up);
                resetpos = false;
            }
            /*float axisVertical = Input.GetAxisRaw("Vertical");
            transform.Translate(speedPlayer * Time.deltaTime * new Vector3(axisVertical, 0, 0));*/
            MovePlayer3D();
            RotatePlayer3D();
        }
    }
    private void MovePlayer3D()
    {
        float axisVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(axisVertical, 0, 0));
    }
    private void RotatePlayer3D()
    {
        float axisHorizontal = Input.GetAxisRaw("Horizontal");
        transform.Rotate(Vector3.up, axisHorizontal * speedToRotate * Time.deltaTime);
    }
    private void MovePlayerX2D(float axisHorizontal)
    {
            transform.Translate(speedPlayer * Time.deltaTime * new Vector3(axisHorizontal, 0, 0));
            if (axisHorizontal == 1)
            {
                RotatePlayer2D(90, Vector3.up);
            }
            else if (axisHorizontal == -1)
            {
                RotatePlayer2D(90, Vector3.down);
            }
        }

    private void MovePlayerZ2D(float axisHorizontal) { 
        transform.Translate(speedPlayer * Time.deltaTime * new Vector3(0, 0, -axisHorizontal));
        if (axisHorizontal == 1)
        {
            RotatePlayer2D(180, Vector3.up);
        }
        else if (axisHorizontal == -1)
        {
            RotatePlayer2D(0, Vector3.up);
        }
    }

    private void RotatePlayer2D(float angle, Vector3 direction)
    {
        player.transform.rotation = Quaternion.AngleAxis(angle, direction);
    }

}
