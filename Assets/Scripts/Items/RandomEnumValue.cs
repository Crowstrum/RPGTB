using UnityEngine;

using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Helpers
{
		public  class RandomEnumValue
		{

				Random _Random = new Random ();
	
				public  T GetRandomEnum<T> ()
				{
						return System.Enum
			.GetValues (typeof(T))
				.Cast<T> ()
				.OrderBy (x => Random.Range (0, int.MaxValue))
				.FirstOrDefault ();
				}
		}
}
