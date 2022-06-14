using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mouseOnCllick : MonoBehaviour
{
    public GameObject latter;
    public GameObject card;
    public GameObject Text;
    // Start is called before the first frame update
    public void OnClickButton()
    {
        if (latter != null)
        {
            latter.SetActive(true);
            card.SetActive(true);
        }
        if (Text != null)
        {
            Text.SetActive(false);
        }
    }
}