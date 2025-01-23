using NodeCanvas.Framework;
using ParadoxNotion.Design;
using Unity.VisualScripting;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions {

	public class InputCheckerCT : ConditionTask {
        public BBParameter<int> currentInput;
        public Blackboard agentBlackboard;
		public Blackboard styleBlackboard;
		float addStyle;
        public BBParameter<GameObject> Style;
        //Use for initialization. This is called only once in the lifetime of the task.
        //Return null if init was successfull. Return an error string otherwise
        protected override string OnInit(){
            agentBlackboard = agent.GetComponent<Blackboard>();
			styleBlackboard = Style.value.GetComponent<Blackboard>();
            
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
            addStyle = styleBlackboard.GetVariableValue<float>("Style");
            if (currentInput.value == 1 && Input.GetKeyDown(KeyCode.W))
			{
				addStyle += 1;
                styleBlackboard.SetVariableValue("Style",addStyle);
                return true;
            }
			else if(currentInput.value == 2 && Input.GetKeyDown(KeyCode.D))
			{
                addStyle += 1;
                styleBlackboard.SetVariableValue("Style", addStyle);
                return true;
            }
            else if (currentInput.value == 3 && Input.GetKeyDown(KeyCode.S))
            {
                addStyle += 1;
                styleBlackboard.SetVariableValue("Style", addStyle);
                return true;
            }
            else if (currentInput.value == 4 && Input.GetKeyDown(KeyCode.A))
            {
                addStyle += 1;
                styleBlackboard.SetVariableValue("Style", addStyle);
                return true;
            }
            else
			{
				return false;
			}
			
		}
	}
}