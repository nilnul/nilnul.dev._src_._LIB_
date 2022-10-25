using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item_.unjoint_.plain
{
	public class Prjs
	{
		public nilnul.fs.folders_.isolated._prjs.Io io;
		public Prjs(nilnul.fs.folders_.isolated._prjs.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> seq_ofAddress(
			string folder
		) {
			if (nilnul.fs.folder.be_.vs_.Prj.Singleton.be_ofAddress(folder) )
			{
				yield return folder;
				yield break; //assume prj is not recursive.
			}

			foreach (var dirAddress in nilnul.fs.folder.dirs_._NotDotLedX.Addresses_ofAddress(folder))
			{

			}

		}
	}
}
