using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreText : MonoBehaviour
{
    //The score text//
    private TextMeshProUGUI text;

    //Sets the text component//
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    //The "score" and "amount/value"//
    private void Update()
    {
        text.text = string.Format("Coin:{0:0}", Coin.score);
    }

}
