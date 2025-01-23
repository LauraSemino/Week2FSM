using NodeCanvas.Framework;
using ParadoxNotion.Design;
using TMPro;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class Style_ManagerAT : ActionTask {
		public Blackboard agentBlackboard;
		public BBParameter<GameObject> Input;
		public BBParameter<float> localStyle;
		public BBParameter<float> localScore;
        public TextMeshPro styleTXT;
        //public TextMeshPro scoreTXT;
        public float styleDecay;
		public string styleLvl;
		float timer;
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
			//EndAction(true);
		}

		//Called once per frame while the action is active.
		protected override void OnUpdate() {

			timer += Time.deltaTime;
			
			//scoreMult = 1f;
			if (localStyle.value >= 0 && timer >= 1)
			{
                localStyle.value -= styleDecay;
				timer = 0;
            }
			if (localStyle.value < 0)
			{
				localStyle.value = 0;
			}
			styleTXT.text = ("Style: " + styleLvl + " (" + localStyle.value + ")");
            //scoreTXT.text = ("Score: " + localScore.value);
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