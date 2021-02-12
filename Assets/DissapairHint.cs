using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapairHint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(Dissapair), 20f);
    }

    void Dissapair()
    {
        transform.gameObject.SetActive(false);
    }
}
