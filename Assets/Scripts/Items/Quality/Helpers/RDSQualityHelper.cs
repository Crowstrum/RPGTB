using UnityEngine;
using System.Collections;
using rds;
using Items;

public class RDSQualityHelper : RDSObject
{

		private Quality _quality = Quality.Poor;

		public RDSQualityHelper (Quality quality)
		{
				_quality = quality;
		}
	
		public Quality GetItemQuality ()
		{
				return _quality;
		}
}
