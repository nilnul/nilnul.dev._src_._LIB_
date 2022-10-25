using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable
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
		)
		{

			var dirs = nilnul.fs.folder.dirs_.notDotLed_.deV_._ExcludeAutogenX.Dirs_ofAddress(folder);

			foreach (var dir in dirs)
			{
				var dirAddress = System.IO.Path.Combine(folder, dir.ToString());

				foreach (
					var item
					in
					new dir_.noDotLed_.noAutogen.InsideModules(io).addresses_ofAddress(
						dirAddress
					)
				)
				{
					yield return item;
				}

			}

			if (new System.IO.DirectoryInfo(folder).EnumerateDirectories().Any(
				d => d.Name.ToLower() == ".git"
				)
			)
			{
				yield return folder;
			}


		}
	}
}





