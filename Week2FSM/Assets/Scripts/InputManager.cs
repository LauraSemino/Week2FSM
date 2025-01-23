using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class InputManager : ActionTask {
        public Blackboard agentBlackboard;
		public BBParameter<int> currentInput;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
            agentBlackboard = agent.GetComponent<Blackboard>();
			currentInput = 1;
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

            if (currentInput.ConvertTo<int>() < 4)
			{
                currentInput = inputSequence;
            }
			if (currentInput.ConvertTo<int>() >= 4)
			{
				currentInput = 1;
			}
			
            EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			//currentInput = agentBlackboard.GetVariableValue<float>("InputSequence");
			
        }

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}