using UnityEngine;
using UnityEngine.Events;

namespace ProjectScripts
{
	public class EventScript : MonoBehaviour
	{
		public UnityEvent Event;

		private void OnMouseDown()
		{
			Event.Invoke();
		}

		private void OnTriggerEnter(Collider other)
		{
			Event.Invoke();
		}
	}
}
