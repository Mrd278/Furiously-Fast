
var Carcontrol : GameObject;
var opponent1 : GameObject;
var opponent2 : GameObject;
var opponent3 : GameObject;
var opponent4 : GameObject;
function Start(){
	Carcontrol.GetComponent("CarController").enabled=true;
    opponent1.GetComponent("CarAIControl").enabled=true;
    opponent2.GetComponent("CarAIControl").enabled=true;
    opponent3.GetComponent("CarAIControl").enabled=true;
    opponent4.GetComponent("CarAIControl").enabled=true;
}