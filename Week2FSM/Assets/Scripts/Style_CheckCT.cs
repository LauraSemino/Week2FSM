using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class Style_CheckCT : ConditionTask {
        public Blackboard agentBlackboard;
        public BBParameter<float> localStyle;
        public float requiredStyle;
		public float lowerLimitStyle;
		//Use for initialization. This is called only once in the lifetime of the task.
		//Return null if init was successfull. Return an error string otherwise
		protected override string OnInit(){
            agentBlackboard = agent.GetComponent<Blackboard>();
            return null;
		}

		//Called whenever the condition gets enabled.
		protected override void OnEnable() {
			
		}

		//Called whenever the condition gets disabled.
		protected override void OnDisable() {
			
		}

		//Called once per frame while the condition is active.
		//Return whether the condition is success or failure.
		protected override bool OnCheck() {
			
			
			if (localStyle.value >= requiredStyle)
			{
                return true;
            }
			else if (localStyle.value < lowerLimitStyle)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
	}
}