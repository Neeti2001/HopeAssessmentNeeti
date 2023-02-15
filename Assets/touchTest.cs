using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class touchTest : MonoBehaviour
{
    GameObject pager;

    // Start is called before the first frame update
    void Start()
    {
        pager = GameObject.Find("pager");
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        pager.SetActive(true);
        //Destroy(gameObject.transform.parent.gameObject);
    }
}