using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utilities : MonoBehaviour
{
    [SerializeField] private GameObject player;
    public void Toggle(GameObject go)
    {
        go.SetActive(!go.activeSelf);
    }

    public void SetPlayerPosition(Transform target)
    {
        player.transform.position = target.position;
        player.transform.rotation = target.rotation;
    }
}
