var minFlickerSpeed : float = 0.1;

var maxFlickerSpeed : float = 1.0;

 var LightOn :Material ;
 var LightOff :Material ;
 
while (true) {



    gameObject.renderer.material = LightOn;

     yield WaitForSeconds (Random.Range(minFlickerSpeed, maxFlickerSpeed ));

     gameObject.renderer.material = LightOff;

     yield WaitForSeconds (Random.Range(minFlickerSpeed, maxFlickerSpeed ));

}