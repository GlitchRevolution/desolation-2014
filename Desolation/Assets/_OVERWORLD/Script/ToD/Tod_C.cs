using UnityEngine;
using System.Collections;

public class Tod_C : MonoBehaviour {

	public static Tod_C currentHour;
	public float slider;
	public float slider2;
	public float Hour;
	private float timeOfDay;
	public float secondsPerDay;
	public Light sun;
	public Color NightFogColor;
	public Color DuskFogColor;
	public Color MorningFogColor;
	public Color MiddayFogColor;
	public Color NightAmbientLight;
	public Color DuskAmbientLight;
	public Color MorningAmbientLight;
	public Color MiddayAmbientLight;
	public Color  NightTint;
	public Color  DuskTint;
	public Color  MorningTint;
	public Color  MiddayTint;
	public Material SkyBoxMaterial1;
	public Material SkyBoxMaterial2;
	public Color SunNight;
	public Color SunDay;
	private float sunAngle; 
	private float lightIntensity;

	void Awake () {
		currentHour = this;
		}
	void OnGUI () {
				sunAngle = sun.transform.localEulerAngles.x;
				sun.intensity = lightIntensity;	
				Hour = slider * 24;
				timeOfDay = slider2 * 24;
				sunAngle = (slider * 360) - 90;
				slider = slider + Time.deltaTime / (secondsPerDay*2);
				sun.color = Color.Lerp (SunNight, SunDay, slider * 2);
				if (slider < 0.5) {
						slider2 = slider;
				}
				if (slider > 0.5) {
						slider2 = (1 - slider);
				}
				lightIntensity = (float)(slider2 - 0.2) * 2;
				if (slider >= 1) {
						slider = 0;
				}

	
		if(timeOfDay<4){
				//it is Night
				RenderSettings.skybox=SkyBoxMaterial1;
				RenderSettings.skybox.SetFloat("_Blend", 0);
				SkyBoxMaterial1.SetColor ("_Tint", NightTint);
				RenderSettings.ambientLight = NightAmbientLight;
				RenderSettings.fogColor = NightFogColor;
				}
		if(timeOfDay>4&&timeOfDay<6){
				RenderSettings.skybox=SkyBoxMaterial1;
				RenderSettings.skybox.SetFloat("_Blend", 0);
				RenderSettings.skybox.SetFloat("_Blend", (timeOfDay/2)-2);
				SkyBoxMaterial1.SetColor ("_Tint", Color.Lerp (NightTint, DuskTint, (timeOfDay/2)-2) );
				RenderSettings.ambientLight = Color.Lerp (NightAmbientLight, DuskAmbientLight, (timeOfDay/2)-2);
				RenderSettings.fogColor = Color.Lerp (NightFogColor,DuskFogColor, (timeOfDay/2)-2);
				//it is Dusk
				}
		if(timeOfDay>6&&timeOfDay<8){
				RenderSettings.skybox=SkyBoxMaterial2;
				RenderSettings.skybox.SetFloat("_Blend", 0);
				RenderSettings.skybox.SetFloat("_Blend", (timeOfDay/2)-3);
				SkyBoxMaterial2.SetColor ("_Tint", Color.Lerp (DuskTint,MorningTint,  (timeOfDay/2)-3) );
				RenderSettings.ambientLight = Color.Lerp (DuskAmbientLight, MorningAmbientLight, (timeOfDay/2)-3);
				RenderSettings.fogColor = Color.Lerp (DuskFogColor,MorningFogColor, (timeOfDay/2)-3);
				//it is Morning
				}
		if(timeOfDay>8&&timeOfDay<10){
				RenderSettings.ambientLight = MiddayAmbientLight;
				RenderSettings.skybox=SkyBoxMaterial2;
				RenderSettings.skybox.SetFloat("_Blend", 1);
				SkyBoxMaterial2.SetColor ("_Tint", Color.Lerp (MorningTint,MiddayTint,  (timeOfDay/2)-4) );
				RenderSettings.ambientLight = Color.Lerp (MorningAmbientLight, MiddayAmbientLight, (timeOfDay/2)-4);
				RenderSettings.fogColor = Color.Lerp (MorningFogColor,MiddayFogColor, (timeOfDay/2)-4);
				//it is getting Midday
				}
	}
}