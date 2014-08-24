using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LDUtils {

	public static float getDistance2D(Vector2 vec0, Vector2 vec1)
	{
		float a = Mathf.Pow(vec0.x - vec1.x), 2);
		float b = Mathf.Pow(vec0.y - vec1.y), 2);

		float c = Mathf.Sqrt(a+b);

		return c;
	}

	public static List <Vector4> planetColors = new List <Vector4> ();

	public static void LoadColors()
	{
		planetColors.Add(new Vector4(0,0,0,1));
		planetColors.Add(new Vector4(1,1,0,1));
		planetColors.Add(new Vector4(0,0,1,1));
		planetColors.Add(new Vector4(0.09765625f, 0.09765625f, 0.4375f, 1));
		planetColors.Add(new Vector4(0,.5f,.5f,1));
		planetColors.Add(new Vector4(1,0,0,1));
		planetColors.Add(new Vector4(1,0.078125f,0.0022430419921875f));
		planetColors.Add(new Vector4(1,0.026900585f, 0,1));
		planetColors.Add(new Vector4(.75f,.75f,.75f,1));
		planetColors.Add(new Vector4(1, 0.83984375f, 0,1));
		planetColors.Add(new Vector4(1,1,0.875f,1));
		planetColors.Add(new Vector4(0.95703125f, 0.95703125f, 0.95703125f, 1 ));
		planetColors.Add(new Vector4(0.796875f, 1, 1, 1));
	}


	public static List <string> planetNames = new List <string>();

	public static void LoadPlanetNames()
	{
		planetNames.Add("Amobo");
		planetNames.Add("Griit");
		planetNames.Add("Scyyni");
		planetNames.Add("Rogka");
		planetNames.Add("Tarc");
		planetNames.Add("Fabin");
		planetNames.Add("Rodin");
		planetNames.Add("Bei");
		planetNames.Add("Yurt");
		planetNames.Add("Aiur");
		planetNames.Add("Krop");
		planetNames.Add("Rnat");
		planetNames.Add("Byinf");
		planetNames.Add("Merk");
		planetNames.Add("K'tha");
		planetNames.Add("Unitar");
		planetNames.Add("Heelop");
		planetNames.Add("Treebz");
		planetNames.Add("Byrnol");
		planetNames.Add("Patfinsh");
		planetNames.Add("Glyyf");
		planetNames.Add("Soni");
		planetNames.Add("Eirat");
		planetNames.Add("Tesin");
		planetNames.Add("Steph");
		planetNames.Add("Disik");
		planetNames.Add("Bardinier");
		planetNames.Add("Yarx");
		planetNames.Add("Defcry");
		planetNames.Add("Ferd");
		planetNames.Add("Fupa");
		planetNames.Add("Shakuras");
		planetNames.Add("Earth");
		planetNames.Add("Venus");
		planetNames.Add("Mercury");
		planetNames.Add("Jak");
		planetNames.Add("Tinzit");
		planetNames.Add("Ononono");
		planetNames.Add("Qwerty");
		planetNames.Add("Yop");
		planetNames.Add("Nivivin");
		planetNames.Add("Uushi");
		planetNames.Add("Hushnin");
		planetNames.Add("Blyvad");
		planetNames.Add("Qpon");
		planetNames.Add("Gonia");
		planetNames.Add("Bantha");
		planetNames.Add("Banana");
		planetNames.Add("Auraxis");
		planetNames.Add("Yunini");
		planetNames.Add("Gethinz");
		planetNames.Add("Kr'tal");
		planetNames.Add("Hroth");
		planetNames.Add("Bzzt");
		planetNames.Add("Binic");
		planetNames.Add("New_England");
		planetNames.Add("OPO");
		planetNames.Add("Niyt");
		planetNames.Add("Apocol");
		planetNames.Add("Yptic");
		planetNames.Add("Luc");
		planetNames.Add("Ario");
		planetNames.Add("Choo");
		planetNames.Add("Nazir");
		planetNames.Add("Bleg");
		planetNames.Add("YyyFyyZ");
		planetNames.Add("Nod");
		planetNames.Add("Kur-La");
		planetNames.Add("Izy");
		planetNames.Add("Crystal");
		planetNames.Add("Uniti");
		planetNames.Add("Serenity");
		planetNames.Add("Naz");
		planetNames.Add("Exelcior");
		planetNames.Add("Poo");
		planetNames.Add("Shining_Light");
		planetNames.Add("USSA");
		planetNames.Add("Connie");
		planetNames.Add("Burt");
		planetNames.Add("Ernie");
		planetNames.Add("Twerk");
		planetNames.Add("Han");
		planetNames.Add("Solo");
		planetNames.Add("Skydin");
		planetNames.Add("Dragon-earth");
		planetNames.Add("Fizzle");
		planetNames.Add("Shizzle");
		planetNames.Add("Stormwind");
		planetNames.Add("Overlord");
		planetNames.Add("Hydra");
		planetNames.Add("SiPool");
		planetNames.Add("Archon");
		planetNames.Add("Magikarp");
		planetNames.Add("Naix");
		planetNames.Add("Clark");
		planetNames.Add("Never_gonna_give_you_up");
		planetNames.Add("Never_gonna_let_you_down");
		planetNames.Add("Swar");
		planetNames.Add("Vadi");
		planetNames.Add("Hornet");
		planetNames.Add("Andrid");
		planetNames.Add("Astrid");
		planetNames.Add("Hiccup");
		planetNames.Add("Apparation");
		planetNames.Add("Mi");
	}

}
 	