using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] Transform target = default;

    void LateUpdate()
    {
        transform.position = target.position;
    }
}
