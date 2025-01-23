using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class Style_ManagerAT : ActionTask {
		public Blackboard agentBlackboard;
		public BBParameter<GameObject> Input;
		float localStyle;
		float localScore;
		float scoreMult;
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
			EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {
			
			localStyle = agentBlackboard.GetVariableValue<float>("Style");
			localStyle -= Time.deltaTime;
			//agentBlackboard.SetVariableValue<float>("Style", localStyle);
		}

		//Called when the task is disabled.
		protected override void OnStop() {
			
		}

		//Called when the task is paused.
		protected override void OnPause() {
			
		}
	}
}