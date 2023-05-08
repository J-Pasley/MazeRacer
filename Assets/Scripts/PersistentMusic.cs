using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentMusic : MonoBehaviour
{
	void Awake()
	{
		DontDestroyOnLoad(transform.gameObject);
	}
}
