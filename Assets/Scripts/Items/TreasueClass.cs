using UnityEngine;
using System.Collections;
using rds;
using Items;
using Items.Affix;

public class TreasueClass : MonoBehaviour
{
		RDSTable pickItemQuality;
		RDSTable pickItemTable;
		GameObject test;
		AffixItemType Itype;
		private RDSTable treasureTable;
		private RDSTable qualityTable;
		private RDSTable tcOne;
		private RDSTable tcOneA;
		private RDSTable tcOneB;
		private RDSTable qualityTableOne;
		private RDSTable affixTable;

		void Start ()
		{
				affixTable = new RDSTable ();
				qualityTable = new RDSTable ();
				treasureTable = new RDSTable ();
				qualityTableOne = new RDSTable ();
				tcOne = new RDSTable ();
				tcOneA = new RDSTable ();
				tcOneB = new RDSTable ();
				SetupTcOne ();
				SetupQualityOne ();
				SetupAffixTable ();

		}
		
		void SetupAffixTable ()
		{
				affixTable.AddEntry (new RDSAffixHelper (), 100);
		}

		void SetupTcOne ()
		{
				tcOne.AddEntry (new RDSItemHelper (1), 100);
				
		}
		
		void SetupQualityOne ()
		{
				qualityTableOne.AddEntry (new RDSQualityHelper (Quality.Common), 50);
				qualityTableOne.AddEntry (new RDSQualityHelper (Quality.Rare), 25);
				qualityTableOne.AddEntry (new RDSQualityHelper (Quality.Fabled), 10);
		}

		void PickTable (int tcLevel)
		{
				//RDSTable tableReturn;
				switch (tcLevel) {
				case 1:
						treasureTable.AddEntry (tcOne, 100);
						qualityTable.AddEntry (qualityTableOne, 100);
						
						pickItemTable = treasureTable;
						pickItemQuality = qualityTable;
						break;
				default:
						pickItemTable = null;
						break;
				}
				//return tableReturn;
		}

		void Update ()
		{
				if (Input.GetKeyDown (KeyCode.W)) {
						
						
						PickTable (1);
						
						
						
						foreach (RDSItemHelper type in pickItemTable.rdsResult) {
								
								test = (GameObject)Instantiate (type.GetItem ().gameObject, Vector3.zero, Quaternion.identity);
						}
						foreach (RDSQualityHelper qual in pickItemQuality.rdsResult) {
								Itype = test.GetComponent<Weapon> ().affixType;
								test.GetComponent<Weapon> ().SetQuality (qual.GetItemQuality ());
								
								//test.GetComponent<Weapon> ().ItemAffixs.Add ();
								//	te.Affixs [0] = new StrengthAffix (1, Quality.Fabled);
						}
						foreach (RDSAffixHelper affix in affixTable.rdsResult) {
								test.GetComponent<Weapon> ().ItemAffixs.Add (affix.GetAffix (Itype));
						}
						
				}
		}
}

