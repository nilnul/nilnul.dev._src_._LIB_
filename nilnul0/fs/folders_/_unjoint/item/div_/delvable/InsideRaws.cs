using nilnul.fs.folder.be;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_._unjoint.item.div_.delvable
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
		)
		{
			if (nilnul.fs.folder.be_.Neglect.Singleton.Be_ofAddress(folder) )
			{
				yield break;
				//return new string[0];
			}

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
			yield return folder;
		}
	}
}





