using UnityEngine;
using System.Collections;
using rds;

public class Gold :  RDSValue<double>
{

		public Gold (int max, int min) : base (0,1)
		{
				rdsValue = Random.Range (min, max);
		}
}
