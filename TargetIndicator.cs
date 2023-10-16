using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetIndicator : MonoBehaviour
{
    public Transform target;
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Transform target4;

    private bool isTargetActive = true;
    private bool isTarget1Active = false;
    private bool isTarget2Active = false;
    private bool isTarget3Active = false;
    private bool isTarget4Active = false;

    private void Update()
    {
        if (isTargetActive)
        {
            RotateTowardsTarget(target);
        }
        else if (isTarget1Active)
        {
            RotateTowardsTarget(target1);
        }
        else if (isTarget2Active)
        {
            RotateTowardsTarget(target2);
        }
        else if (isTarget3Active)
        {
            RotateTowardsTarget(target3);
        }
        else if (isTarget4Active)
        {
            RotateTowardsTarget(target4);
        }
    }

    private void RotateTowardsTarget(Transform currentTarget)
    {
        var direction = currentTarget.position - transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("onjective"))
        {
            if (isTargetActive)
            {
                isTargetActive = false;
                isTarget1Active = true;
            }
            else if (isTarget1Active)
            {
                isTarget1Active = false;
                isTarget2Active = true;
            }
            else if (isTarget2Active)
            {
                isTarget2Active = false;
                isTarget3Active = true;
            }
            else if (isTarget3Active)
            {
                isTarget3Active = false;
                isTarget4Active = true;
            }
            else if (isTarget4Active)
            {
                isTarget4Active = false;
            }
        }
    }
}


