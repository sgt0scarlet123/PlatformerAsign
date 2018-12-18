using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RouteText : MonoBehaviour
{
    //The route text//
    private TextMeshProUGUI text;

    //Sets the text component//
    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    //The "route"//
    private void Update()
    {
        if (Coin.Passive == true)
        {
        text.text = string.Format("Route:{0:0}","Passifist");
        }
        if (Coin.Passive == false)
        {
        text.text = string.Format("Route:{0:0}","Genocide");
        }
        if (Coin.Neutral == true)
        {
            text.text = string.Format("Route:{0:0}", "Neutral");
        }
    }

}
