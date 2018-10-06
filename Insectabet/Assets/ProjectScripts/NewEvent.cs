using UnityEngine;

//Made By Anthony Romrell
namespace ProjectScripts
{
	public class NewEvent : MonoBehaviour
	{
		//public UnityEvent Event;
		public int EmitRate = 100;
		public ParticleSystem Particles;
	
		private void OnMouseDown()
		{
			Particles.Emit(EmitRate);
		}
	}
}