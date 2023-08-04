using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround_Manager : MonoBehaviour
{
    public Transform cameraTransform;
    private void LateUpdate()
    {
        this.transform.position = new Vector3(cameraTransform.position.x , cameraTransform.position.y , 10f);
    }
}
