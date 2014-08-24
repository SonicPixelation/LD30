using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LDUtils {

	public static float getDistance2D(Vector2 vec0, Vector2 vec1)
	{
		float a = Mathf.Pow((vec0.x - vec1.x),2);
		float b = Mathf.Pow((vec0.y - vec1.y),2);

		float c = Mathf.Sqrt(a+b);

		return c;
	}

	public static List <Vector4> planetColors = new List <Vector4>();
	{
		planetColors.Add(new Vector4(0,0,0,1));
		planetColors.Add(new Vector4(1,1,0,1));
		planetColors.Add(new Vector4(0,0,1,1));
		planetColors.Add(new Vector4(0.09765625, 0.09765625, 0.4375, 1));
		planetColors.Add(new Vector4(0,.5,.5,1));
		planetColors.Add(new Vector4(1,0,0,1));
		planetColors.Add(new Vector4(1,0.078125,0.0022430419921875));
		planetColors.Add(new Vector4(1,0.026900585, 0,1));
		planetColors.Add(new Vector4(.75,.75,.75,1));
		planetColors.Add(new Vector4(1, 0.83984375, 0,1));
		planetColors.Add(new Vector4(1,1,0.875,1));
		planetColors.Add(new Vector4(0.95703125, 0.95703125, 0.95703125, 1 ));
		planetColors.Add(new Vector4(0.796875, 1, 1, 1));
	}


	public static List <string> planetNames = new List <string>();
	{
		planetNames.Add(new string("Amobo"));
		planetNames.Add(new string("Griit"));
		planetNames.Add(new string("Scyyni"));
		planetNames.Add(new string("Rogka"));
		planetNames.Add(new string("Tarc"));
		planetNames.Add(new string("Fabin"));
		planetNames.Add(new string("Rodin"));
		planetNames.Add(new string("Bei"));
		planetNames.Add(new string("Yurt"));
		planetNames.Add(new string("Aiur"));
		planetNames.Add(new string("Krop"));
		planetNames.Add(new string("Rnat"));
		planetNames.Add(new string("Byinf"));
		planetNames.Add(new string("Merk"));
		planetNames.Add(new string("K'tha"));
		planetNames.Add(new string("Unitar"));
		planetNames.Add(new string("Heelop"));
		planetNames.Add(new string("Treebz"));
		planetNames.Add(new string("Byrnol"));
		planetNames.Add(new string("Patfinsh"));
		planetNames.Add(new string("Glyyf"));
		planetNames.Add(new string("Soni"));
		planetNames.Add(new string("Eirat"));
		planetNames.Add(new string("Tesin"));
		planetNames.Add(new string("Steph"));
		planetNames.Add(new string("Disik"));
		planetNames.Add(new string("Bardinier"));
		planetNames.Add(new string("Yarx"));
		planetNames.Add(new string("Defcry"));
		planetNames.Add(new string("Ferd"));
		planetNames.Add(new string("Fupa"));
		planetNames.Add(new string("Shakuras"));
		planetNames.Add(new string("Earth"));
		planetNames.Add(new string("Venus"));
		planetNames.Add(new string("Mercury"));
		planetNames.Add(new string("Jak"));
		planetNames.Add(new string("Tinzit"));
		planetNames.Add(new string("Ononono"));
		planetNames.Add(new string("Qwerty"));
		planetNames.Add(new string("Yop"));
		planetNames.Add(new string("Nivivin"));
		planetNames.Add(new string("Uushi"));
		planetNames.Add(new string("Hushnin"));
		planetNames.Add(new string("Blyvad"));
		planetNames.Add(new string("Qpon"));
		planetNames.Add(new string("Gonia"));
		planetNames.Add(new string("Bantha"));
		planetNames.Add(new string("Banana"));
		planetNames.Add(new string("Auraxis"));
		planetNames.Add(new string("Yunini"));
		planetNames.Add(new string("Gethinz"));
		planetNames.Add(new string("Kr'tal"));
		planetNames.Add(new string("Hroth"));
		planetNames.Add(new string("Bzzt"));
		planetNames.Add(new string("Binic"));
		planetNames.Add(new string("New_England"));
		planetNames.Add(new string("OPO"));
		planetNames.Add(new string("Niyt"));
		planetNames.Add(new string("Apocol"));
		planetNames.Add(new string("Yptic"));
		planetNames.Add(new string("Luc"));
		planetNames.Add(new string("Ario"));
		planetNames.Add(new string("Choo"));
		planetNames.Add(new string("Nazir"));
		planetNames.Add(new string("Bleg"));
		planetNames.Add(new string("YyyFyyZ"));
		planetNames.Add(new string("Nod"));
		planetNames.Add(new string("Kur-La"));
		planetNames.Add(new string("Izy"));
		planetNames.Add(new string("Crystal"));
		planetNames.Add(new string("Uniti"));
		planetNames.Add(new string("Serenity"));
		planetNames.Add(new string("Naz"));
		planetNames.Add(new string("Exelcior"));
		planetNames.Add(new string("Poo"));
		planetNames.Add(new string("Shining_Light"));
		planetNames.Add(new string("USSA"));
		planetNames.Add(new string("Connie"));
		planetNames.Add(new string("Burt"));
		planetNames.Add(new string("Ernie"));
		planetNames.Add(new string("Twerk"));
		planetNames.Add(new string("Han"));
		planetNames.Add(new string("Solo"));
		planetNames.Add(new string("Skydin"));
		planetNames.Add(new string("Dragon-earth"));
		planetNames.Add(new string("Fizzle"));
		planetNames.Add(new string("Shizzle"));
		planetNames.Add(new string("Stormwind"));
		planetNames.Add(new string("Overlord"));
		planetNames.Add(new string("Hydra"));
		planetNames.Add(new string("SiPool"));
		planetNames.Add(new string("Archon"));
		planetNames.Add(new string("Magikarp"));
		planetNames.Add(new string("Naix"));
		planetNames.Add(new string("Clark"));
		planetNames.Add(new string("Never_gonna_give_you_up"));
		planetNames.Add(new string("Never_gonna_let_you_down"));
		planetNames.Add(new string("Swar"));
		planetNames.Add(new string("Vadi"));
		planetNames.Add(new string("Hornet"));
		planetNames.Add(new string("Andrid"));
		planetNames.Add(new string("Astrid"));
		planetNames.Add(new string("Hiccup"));
		planetNames.Add(new string("Apparation"));
		planetNames.Add(new string("Mi"));

	}
}
 	