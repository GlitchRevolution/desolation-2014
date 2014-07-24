var minFlickerSpeed : float = 0.1;

var maxFlickerSpeed : float = 1.0;

 

while (true) {

     light.enabled = true;

     yield WaitForSeconds (Random.Range(minFlickerSpeed, maxFlickerSpeed ));

     light.enabled = false;

     yield WaitForSeconds (Random.Range(minFlickerSpeed, maxFlickerSpeed ));

}