using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuberotate : MonoBehaviour
{
    public float spinforce = 45f;

    private bool isSpinning = false;

    // Update is called once per frame
    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(0, spinforce * Time.deltaTime, 0);
        }
        else if (!isSpinning)
        {
            transform.Rotate(0, 0, 0);
        }
    }

    public void ChangeSpin()
    {
        isSpinning = !isSpinning;
    }
}
