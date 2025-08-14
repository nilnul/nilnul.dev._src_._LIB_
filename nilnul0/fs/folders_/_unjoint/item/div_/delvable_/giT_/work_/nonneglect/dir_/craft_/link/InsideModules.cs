using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable_.giT_.work_.nonneglect.dir_.craft_.link
{
	public class InsideModules
	{
		nilnul.fs.folders_._unjoint.Io io;

		public InsideModules(nilnul.fs.folders_._unjoint.Io io)
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

				return new unjoint.InsideModules(io).addresses_ofAddress(folder);

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
