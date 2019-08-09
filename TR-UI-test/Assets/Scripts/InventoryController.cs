using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
	[SerializeField]
	private Text nameText;
	[SerializeField]
	private Text DescriptionText;
	[SerializeField]
	private Image PillsImage;
	[SerializeField]
	private Image EtherImage;
	[SerializeField]
	private Image ShotgunSupplyImage;
	[SerializeField]
	private Image RarityBackdrop;

	//used to refresh the image every time the page is switched.
	public void Refresh()
	{
		PillsImage.enabled = false;
		EtherImage.enabled = false;
		ShotgunSupplyImage.enabled = false;
		RarityBackdrop.color = Color.black;
		nameText.text = "";
		DescriptionText.text = "";
	}

	//private void ItemSelect()
	//{
	//	if(isPainpills == true)
	//	{
	//		nameText.text = "Pain pills";
	//		DescriptionText.text = "Fast acting aspirin to ease pain." + "\n" + "\n" + "Restores 20% HP on use.";
	//	}
	//	else if (isEther1 == true)
	//	{
	//		nameText.text = "Ancient Ether";
	//		DescriptionText.text = "Nectar from the Guardians." + "\n" + "\n" + "Restores 30% Time Energy on use.";
	//	}
	//	else if(isShotgunRestore == true)
	//	{
	//		nameText.text = "Shotgunner's supplies";
	//		DescriptionText.text = "A crate of 000 Buckshot." + "\n" + "\n" + "Grants 16 shotgun shells on use.";
	//	}
	//}

	public void Restorative1()
	{
		RarityBackdrop.color = Color.green;
		EtherImage.enabled = false;
		PillsImage.enabled = true;
		ShotgunSupplyImage.enabled = false;
		nameText.text = "Pain pills";
		DescriptionText.text = "Fast acting aspirin to ease pain." + "\n" + "\n" + "Restores 20% HP on use.";
	}

	public void Restorative2()
	{
		RarityBackdrop.color = Color.green;
		PillsImage.enabled = false;
		EtherImage.enabled = true;
		ShotgunSupplyImage.enabled = false;
		nameText.text = "Ancient Ether";
		DescriptionText.text = "Nectar from the Guardians." + "\n" + "\n" + "Restores 30% Time Energy on use.";
	}

	public void Restorative3()
	{
		RarityBackdrop.color = Color.blue;
		PillsImage.enabled = false;
		EtherImage.enabled = false;
		ShotgunSupplyImage.enabled = true;
		nameText.text = "Shotgunner's supplies";
		DescriptionText.text = "A crate of 000 Buckshot." + "\n" + "\n" + "Grants 16 shotgun shells on use.";
	}
}
