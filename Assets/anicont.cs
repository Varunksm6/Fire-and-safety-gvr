using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anicont : MonoBehaviour
{

    [SerializeField]
    GameObject GameObject;
    [SerializeField]
    string explodeParameterName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void AnimationController(bool status)
    {
        GameObject.GetComponent<Animator>().SetBool(explodeParameterName, status);
    }
}
