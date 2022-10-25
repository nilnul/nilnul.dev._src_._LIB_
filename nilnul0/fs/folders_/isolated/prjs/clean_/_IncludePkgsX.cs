using nilnul.obj;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.isolated.prjs.clean_
{
	static public class _IncludePkgsX
	{
		static public void Clean(IEnumerable<string > folders) {
			var prjs = nilnul.fs.folders_.isolated.Prjs.Seq(folders);

			prjs.Each(
				p => nilnul.dev.prj_.cs.clean_._IncludePkgsX.Vod_assumeCsSynd(p)
			);

		}

		public static void Clean(IEnumerable<string> folders, StreamWriter log)
		{
			var prjs = nilnul.fs.folders_.isolated.Prjs.Seq(folders,log);

			prjs.Each(
				p => nilnul.dev.prj_.cs.clean_._IncludePkgsX.Vod_assumeCsSynd(p
				
				)
			);

			//throw new NotImplementedException();
		}

		static public void Clean(params string[] folders) {
			Clean(
				(IEnumerable<string>)folders
			);

		}
		static public void Clean( string folders, StreamWriter log) {
			Clean(
				new[] { folders }
				,
				log
			);

		}


	}
}
