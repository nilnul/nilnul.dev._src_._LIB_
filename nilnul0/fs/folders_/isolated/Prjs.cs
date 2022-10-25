using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.isolated
{
	 public class Prjs
	{
		static public IEnumerable<string> Seq(
			
			_prjs.Io io
		) {


			foreach (var item in io.destinySrc.Values)
			{

				foreach (var item1 in new _isolated.item.Prjs(io).seq_ofAddress(item) )
				{
					yield return item1;
				}
				;
			}


		}

		static public IEnumerable<string> Seq(
			IEnumerable<string> foldersIsolated
			
		) {
			///add actual trees.
			///

			return Seq(
				
				 _prjs.Io.OfAddresses_removeNonfolder(
				foldersIsolated
			));
		}

		public static IEnumerable<string> Seq(
			IEnumerable<string> folders
			,
			StreamWriter log
		)
		{
			return Seq(
				
				 _prjs.Io.OfAddresses_removeNonfolder(
				folders,log
			));


		}
	}
}
