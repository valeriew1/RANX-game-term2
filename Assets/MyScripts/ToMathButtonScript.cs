using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ToMathButtonScript: MonoBehaviour
{
    [SerializeField] Button ToMathButton;
    void Start()
    {
        ToMathButton.onClick.AddListener(onToMathButton);
    }

    public void onToMathButton() 
    {
        // GameManager.Instance.LoadScene("Math"); //почему ты не работаешь урод :/
        SceneManager.LoadScene("Math");
    }


}