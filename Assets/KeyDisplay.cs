using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyDisplay : MonoBehaviour
{
    [SerializeField]
    private Image key;

    [SerializeField]
    private Sprite empty;

    [SerializeField]
    private Sprite full;
    // Start is called before the first frame update
    void Start()
    {
        key.sprite = empty;
    }

    void Update()
    {
        if (CollectKey.collect)
        {
            key.sprite = full;
        }
    }
}
