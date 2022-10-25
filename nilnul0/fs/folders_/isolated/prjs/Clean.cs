using nilnul.obj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.isolated.prjs
{
	/// <summary>
	/// 
	/// </summary>
	static public class CleanX
	{
		static public void Clean(IEnumerable<string > folders) {
			var prjs = nilnul.fs.folders_.isolated.Prjs.Seq(folders);

			prjs.Each(
				p => nilnul.dev.prj_.cs._CleanX.Vod_assumeCsSynd(p)
			);

		}
		static public void Clean(params string[] folders) {
			Clean(
				(IEnumerable<string>)folders
			);

		}

	}
}
