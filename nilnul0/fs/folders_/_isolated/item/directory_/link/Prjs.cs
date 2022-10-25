using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._isolated.item.directory_.link
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

				return new directory_.unjoint.Prjs(io).seq_ofAddress(folder);

			}
			else
			{
				return new string[0];
				Trace.TraceWarning(
					$"{folder} is already processed by {old.Key}, which is linked by {old.Value}"
				);

			}

			

		}
	}
}
