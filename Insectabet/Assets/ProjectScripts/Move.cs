using UnityEngine;

//Made By Anthony Romrell
namespace ProjectScripts
{
	public class Move : MonoBehaviour
	{
		public CharacterController Character;
	
		public float Speed;
		public Vector3 MoveSpeed;
		public Vector3 RotateSpeed;
	
		private void Update()
		{
			MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
			MoveSpeed *= Time.deltaTime;

			Character.Move(MoveSpeed);
		}
	}
}
