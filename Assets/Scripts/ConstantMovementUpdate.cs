// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstantMovementUpdate.cs" company="Supyrb">
//   Copyright (c) 2017 Supyrb. All rights reserved.
// </copyright>
// <author>
//   Johannes Deml
//   send@johannesdeml.com
// </author>
// --------------------------------------------------------------------------------------------------------------------

namespace Supyrb
{
    using UnityEngine;
    using System.Collections;
    
    public class ConstantMovementUpdate : MonoBehaviour 
    {
		[SerializeField, Tooltip("per second")] private Vector3 movementVector = Vector3.zero;

		void Update()
		{
			transform.position = transform.position + movementVector * Time.smoothDeltaTime;
		}
    }
}
