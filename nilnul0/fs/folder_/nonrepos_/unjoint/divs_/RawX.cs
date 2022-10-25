using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder_.nonrepos_.unjoint.divs_
{
	 static public class RawX
	{
		

		static public IEnumerable<string> Seq(
			IEnumerable<nilnul.fs.folder_.giT_.Nonrepo> foldersIsolated
			
		) {
			///add actual trees.
			///

			return fs.folders_.unjoint.divs_.RawX. Seq(
				foldersIsolated.Select(
					x=> x.en.address.en.ToString()
				)
			);
		}

		static public IEnumerable<string> Seq(
			IEnumerable<string> foldersIsolated
			
		) {
			///add actual trees.
			///

			return Seq(
				foldersIsolated.Select(
					a=> new nilnul.fs.folder_.giT_.Nonrepo(
						nilnul.fs.Folder.FroAddress(a)
					)
				)
			);
		}
		static public IEnumerable<string> Seq(
			params string[] foldersIsolated
			
		) {
			///add actual trees.
			///

			return Seq(
				
				(IEnumerable<string>)foldersIsolated
			);
		}


	}
}
