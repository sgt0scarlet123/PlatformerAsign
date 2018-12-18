using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class KeyText : MonoBehaviour {

    //The KeyAmount text//
    private TextMeshProUGUI text;

    //Sets the text component//
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    //The "Key" and "amount"//
    private void Update()
    {
        text.text = string.Format("Keys:{0:0}", Key.KeyA);
    }
}
