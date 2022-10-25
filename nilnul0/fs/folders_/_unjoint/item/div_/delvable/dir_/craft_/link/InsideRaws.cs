using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable.dir_.craft_.link
{
	public class InsideRaws
	{
		nilnul.fs.folders_._unjoint.Io io;

		public InsideRaws(nilnul.fs.folders_._unjoint.Io io)
		{
			this.io = io;
		}


		public IEnumerable<string> addresses_ofAddress(
			string folder
		) {
			var old = io._addDestiny_addressAssumeLink(folder);

			if (old.Key is null)
			{
				///unjoint
				///

				return new unjoint.InsideRaws(io).addresses_ofAddress(folder);

			}
			else
			{
				Trace.TraceError( // link shall not cross
					$"{folder} is already processed by {old.Key}, which is linked by {old.Value}"
				);
				return new string[0];

			}

			

		}
	}
}
