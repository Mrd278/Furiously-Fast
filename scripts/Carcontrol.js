var Carcontrol : GameObject;
var opponent_1 : GameObject;
var opponent_2 : GameObject;
function Start(){
	Carcontrol.GetComponent("CarController").enabled=true;
    opponent_1.GetComponent("CarAIControl").enabled=true;
    opponent_2.GetComponent("CarAIControl").enabled=true;
}