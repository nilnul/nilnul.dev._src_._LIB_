using nilnul.fs.address_;
using nilnul.fs.folders_.isolated._prjs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item
{
	public class Prjs
	{
		nilnul.fs.folders_.isolated._prjs.Io io;

		public Prjs(nilnul.fs.folders_.isolated._prjs.Io io)
		{
			this.io = io;
		}


		public IEnumerable<string> seq_ofAddress(
			string folder
		) {
			return new item.div_.unjoint_.nonneglect.Prjs(io).seq_ofAddress(folder);

			

		}

		internal IEnumerable<string> seq_ofAddress(ShieldI item)
		{
			
			return seq_ofAddress(item.ToString());
		}
	}
}
