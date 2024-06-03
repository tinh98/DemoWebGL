using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AccessToken : MonoBehaviour
{
    [SerializeField] private Text _text;
    // Start is called before the first frame update
    void Awake()
    {
        var param = URLParameters.GetSearchParameters();
        string accessToken = param["token"];

        _text.text = accessToken;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
