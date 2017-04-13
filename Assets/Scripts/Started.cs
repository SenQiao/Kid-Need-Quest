using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

namespace AssemblyCSharp
{
	public class Started: MonoBehaviour {


		void Start()
		{
			Time.timeScale = 0;
		
		}

		void Update () 
		{
			if(Input.anyKeyDown)
			{
				Time.timeScale = 1;
				Destroy(gameObject);

			}
		}
	}
}

