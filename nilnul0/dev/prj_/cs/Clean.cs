using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs
{
	/// <summary>
	/// remove bin and obj
	/// </summary>
	static public class _CleanX
	{
		static public void Vod_assumeCsSynd(string container)
		{
			Trace.TraceInformation(
				$"dropping {"bin"} from folder:{container}"
			);
			try
			{

				nilnul.fs.folder.dir._DropX.Drop(
					nilnul.fs.Folder.FroAddress(
					container
					)
					,
					 nilnul.fs._address.Dir.OvDenote(
					"bin"
					)

				);
				Trace.TraceInformation(
				$"dropped {"bin"} from folder:{container}"
				);
			}
			catch (Exception)
			{
				Trace.TraceError(
				$"drop failed of {"bin"} from folder:{container}, due to say, that you are attempting to drop the bin where this test is running."
				);

				//throw;
			}


			Trace.TraceInformation(
				$"dropping {"obj"} from folder:{container}"
			);
			try
			{
				nilnul.fs.folder.dir._DropX.Drop(
					nilnul.fs.Folder.FroAddress(
					container
					)

					,

					 nilnul.fs._address.Dir.OvDenote(
					"obj"
					)

				);
				Trace.TraceInformation(
					$"dropped {"obj"} from folder:{container}"
				);

			}
			catch (Exception)
			{
				Trace.TraceError(
					$"drop failed of {"obj"} from folder:{container}; maybe you are attempting to drop a dir that this test is running at?"
				);

				//throw;
			}


		}
	}
}
