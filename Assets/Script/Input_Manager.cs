using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Input_Manager : MonoBehaviour
{
    private static Input_Manager instance;
    public static Input_Manager Instance { get => instance; }

    [SerializeField] protected Vector3 mouseWorldPos;
    public Vector3 MouseWorldPos { get => mouseWorldPos; }



    private void Awake()
    {
        if(Input_Manager.instance!=null)
        {
            Debug.LogError("only 1 inputManager allow to exist!!!");
        }
        Input_Manager.instance = this;
    }
    private void FixedUpdate()
    {
        this.getMousePos();    
    }
    protected virtual void getMousePos()
    {
        this.mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
