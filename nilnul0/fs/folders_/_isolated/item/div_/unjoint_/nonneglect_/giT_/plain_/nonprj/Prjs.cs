using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.div_.unjoint_.nonneglect_.giT_.plain_.nonprj
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
		)
		{

			foreach (var dirAddress in nilnul.fs.folder._DirsX.Addresses_ofAddress(folder))
			{
				foreach (var item in new directory.Prjs(io).seq_ofAddress(dirAddress))
				{
					yield return item;
				} 
	
			}

		}
	}
}
