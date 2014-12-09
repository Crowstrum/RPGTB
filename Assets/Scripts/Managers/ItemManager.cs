using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Items.Affix;
using Items;
using System.Linq;

public class ItemManager : MonoBehaviour
{
		private static ItemManager _instance;		
		private static List<GameObject> treasureList1;
		public List<GameObject> treasureList1Refrence;
		private static List<BaseAffix> commonAffixList;
		//public List<BaseAffix> commonAffixListRefrence;

		public static ItemManager instance {
				get {
						//If _instance hasn't been set yet, we grab it from the scene!
						//This will only happen the first time this reference is used.
						if (_instance == null) {
								_instance = GameObject.FindObjectOfType<ItemManager> ();
								DontDestroyOnLoad (_instance.gameObject);
						}
						return _instance;
				}
		}

		void Awake ()
		{
				if (_instance == null) {
						//If I am the first instance, make me the Singleton
						_instance = this;
						DontDestroyOnLoad (this);
				} else {
						//If a Singleton already exists and you find
						//another reference in scene, destroy it!
						if (this != _instance)
								Destroy (this.gameObject);
				}
				
				treasureList1 = treasureList1Refrence;
				commonAffixList = new List<BaseAffix> ();
				commonAffixList.Add (new WeaponDamageAffix ());
		}
		
		public GameObject RetrieveItemFromTreasureClass (int tcLevel)
		{
				switch (tcLevel) {
				case 1:
						return ItemManager.treasureList1 [Random.Range (0, treasureList1.Count)];
								
				default:
						return null;
								

				}

		}
		
		public BaseAffix RetrieveAffixFromList (AffixItemType affixType)
		{
				List<BaseAffix> temp = commonAffixList.Where (x => x.GetAffixType () == affixType).ToList ();
				Debug.Log (temp.Count);
				return temp [Random.Range (0, temp.Count)];
		
		}
}
