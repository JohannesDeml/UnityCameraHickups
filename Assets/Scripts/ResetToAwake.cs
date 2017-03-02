using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetToAwake : MonoBehaviour
{

    [SerializeField] private bool resetPosition = true;
    [SerializeField] private bool resetRotation = true;
    [SerializeField] private bool resetLocalScale = true;

    private Vector3 awakePosition;
    private Quaternion awakeRotation;
    private Vector3 awakeLocalScale;

	void Awake ()
	{
	    awakePosition = transform.position;
	    awakeRotation = transform.rotation;
	    awakeLocalScale = transform.localScale;
	}

    [ContextMenu("Reset values")]
    public void ResetTransform()
    {
        if (resetPosition)
        {
            transform.position = awakePosition;
        }

        if (resetRotation)
        {
            transform.rotation = awakeRotation;
        }

        if (resetLocalScale)
        {
            transform.localScale = awakeLocalScale;
        }
    }
}
