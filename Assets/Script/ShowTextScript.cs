using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class ShowTextScript : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Ūzstartēts");
    }

    int kadrs = 0;
    // Update is called once per frame
    void Update()
    {
        kadrs++;
        Debug.Log(kadrs);
    }
    */

    string text;
    public GameObject inputField;
    public GameObject displayField;
    string[] words = { "Sveki ", "Jauku dienu ", "Labrīt ", "Prieks Tevi redzēt " };
    int rd;

    public void getText()
    {
        rd = Random.Range(0, words.Length);
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = words[rd] + text.ToLower() + "!";
    }
}
