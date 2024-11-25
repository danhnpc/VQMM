using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerMarker : MonoBehaviour
{
    public static SpinnerMarker instance;

    public string giftName;

    protected void Awake()
    {
        SpinnerMarker.instance = this;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);
        this.giftName = other.name;
    }
}
