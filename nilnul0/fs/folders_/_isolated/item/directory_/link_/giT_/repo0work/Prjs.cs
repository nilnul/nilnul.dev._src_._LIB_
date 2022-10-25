using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.directory_.link_.giT_.repo0work
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
			var old = io._addDestiny_addressAssumeLink(folder);

			if (old.Key is null)
			{
				///unjoint
				///

			return	new directory_.unjoint_.giT_.repo0work.Prjs(io) .seq_ofAddress(folder);

			}
			else
			{
				Trace.TraceWarning(
					$"{folder} is already processed by {old.Key}, which is linked by {old.Value}"

				);
				return new string[0];

			}

		

		}
	}
}
