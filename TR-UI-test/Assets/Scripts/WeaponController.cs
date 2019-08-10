using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponController : MonoBehaviour
{
	[SerializeField]
	private Image rarityfieldBlue;
	[SerializeField]
	private Image rarityfieldViolet;

	[SerializeField]
	private Text weaponTitle;
	[SerializeField]
	private Text weaponLevel;
	[SerializeField]
	private Text weaponDescription;

	[SerializeField]
	private Image Gun1;
	[SerializeField]
	private Image Gun2;

	[SerializeField]
	private Text statNumbers;

	[SerializeField]
	private Image perkImage;
	[SerializeField]
	private Text perkName;
	[SerializeField]
	private Text perkDesc;

	[SerializeField]
	private Image weaponMod3;

	public void RapidfireFrame()
	{
		weaponMod3.enabled = true;
		rarityfieldBlue.enabled = true;
		rarityfieldViolet.enabled = false;
		weaponTitle.text = "Storm's-a-Brewing";
		weaponLevel.text = "Level 9 Auto rifle";
		weaponDescription.text = "Bring forth the rain.";
		Gun2.enabled = false;
		statNumbers.text = "42" + "\n" + "60" + "\n" + "45" + "\n" + "45" + "\n" + "720 RPM";
		perkImage.enabled = false;
		perkName.text = "";
		perkDesc.text = "";
	}

	public void SinglefireFrame()
	{
		weaponMod3.enabled = false;
		rarityfieldViolet.enabled = true;
		rarityfieldBlue.enabled = false;
		weaponTitle.text = "Arc Conductor";
		weaponLevel.text = "Level 13 Precision rifle";
		weaponDescription.text = "Strike down with lightning.";
		Gun2.enabled = true;
		statNumbers.text = "85" + "\n" + "80" + "\n" + "85" + "\n" + "10" + "\n" + "60 RPM";
		perkImage.enabled = true;
		perkName.text = "Shocking Twist";
		perkDesc.text = "Headshot kills stun nearby enemies.";
	}
}
