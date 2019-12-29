using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    //Config parameters
    [SerializeField] float maxX = 15f;
    [SerializeField] float minX = 1f;
    [SerializeField] float screenWidthInUnits = 16f;
    private void Update() {
        float mouseXPosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePos = new Vector2(mouseXPosInUnits, transform.position.y);
        paddlePos.x = Mathf.Clamp(paddlePos.x, minX, maxX);
        transform.position = paddlePos;
    }
}
