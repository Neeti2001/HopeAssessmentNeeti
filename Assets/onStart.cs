using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onStart : MonoBehaviour
{
    public GameObject pager;

    // Start is called before the first frame update
    void Start()
    {
        pager.SetActive(false);
    }
}
