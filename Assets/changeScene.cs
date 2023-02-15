using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class changeScene : MonoBehaviour
{
    public Button enterBtn;

    void Start()
    {
        Button btnOne = enterBtn.GetComponent<Button>();
        btnOne.onClick.AddListener(TaskOnOneClick);
    }

    void TaskOnOneClick()
    {
        SceneManager.LoadScene("Scanner");
    }

}
