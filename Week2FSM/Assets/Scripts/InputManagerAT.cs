using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class InputManagerAT : ActionTask {
        public BBParameter<Blackboard> agentBlackboard;
		public BBParameter<int> currentInput;
		public BBParameter<TextMeshPro> nextInputTXT;
	
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit() {
            agentBlackboard = agent.GetComponent<Blackboard>();
			
            return null;
		}

		//This is called once each time the task is enabled.
		//Call EndAction() to mark the action as finished, either in success or failure.
		//EndAction can be called from anywhere.
		protected override void OnExecute() {

            if (currentInput.value <= 4)
			{
                currentInput.value ++;
            }
			if (currentInput.value > 4)
			{
				currentInput.value = 1;
			}
			if (currentInput.value == 1)
			{
				nextInputTXT.value.text = "Input: W";
			}
            if (currentInput.value == 2)
            {
                nextInputTXT.value.text = "Input: D";
            }
            if (currentInput.value == 3)
            {
                nextInputTXT.value.text = "Input: S";
            }
            if (currentInput.value == 4)
            {
                nextInputTXT.value.text = "Input: A";
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