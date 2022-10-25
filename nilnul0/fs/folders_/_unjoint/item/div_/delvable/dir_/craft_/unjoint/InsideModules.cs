using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable.dir_.noDotLed_.noAutogen_.unjoint
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

			if (new System.IO.DirectoryInfo(folder).EnumerateDirectories().Any(
				d=>d.Name.ToLower()== ".git"
				)
			)
			{
				return new div_.delvable.InsideModules(io).addresses_ofAddress(folder).Append(folder);
			}

			return new div_.delvable.InsideModules(io).addresses_ofAddress(folder);




		}
	}
}
