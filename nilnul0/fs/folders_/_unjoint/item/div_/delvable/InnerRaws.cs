using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable
{

	[Obsolete("use :" + nameof(InsideRaws), true)]
	public class InnerRaws
	{
		nilnul.fs.folders_._unjoint.Io io;

		public InnerRaws(nilnul.fs.folders_._unjoint.Io io)
		{
			this.io = io;
		}

		public IEnumerable<string> addresses_ofAddress(
			string folder
		)
		{

			var dirs = nilnul.fs.folder.dirs_._ArtisanX.Dirs_ofAddress(folder);

			foreach (var dir in dirs)
			{
				var dirAddress = System.IO.Path.Combine(folder, dir.ToString());

				foreach (
					var item
					in
					new dir_.craft.InsideRaws(io).addresses_ofAddress(
						dirAddress
					)
				)
				{
					yield return item;
				}

			}
		}
	}
}





