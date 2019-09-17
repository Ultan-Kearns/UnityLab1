using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region == Public Variables == 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    #endregion
    private void Move()
    {
        //have an input from user
        var deltaX = Input.GetAxis("Horizontal");
        var deltaY = Input.GetAxis("Vertical");
        var newYPos = transform.position.y + deltaY;
        var newXPos = transform.position.x + deltaX;
        //set current gameobject to new pos
        transform.position = new Vector2(newXPos,transform.position.y);
        transform.position = new Vector2(transform.position.x, newYPos);
    }
}
