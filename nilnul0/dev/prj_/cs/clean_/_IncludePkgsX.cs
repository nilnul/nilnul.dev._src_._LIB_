using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.dev.prj_.cs.clean_
{
	/// <summary>
	/// remove bin and obj
	/// </summary>
	static public class _IncludePkgsX
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

			var dnt = "packages";
			Trace.TraceInformation(
				$"try making {dnt} symlink from folder:{container}"
			);
			try
			{
				nilnul.dev.prj.dnt_.pcks._TryMakeX.Vod_prjAssumeVs_tgtOfFolderAssumeAddress(
					nilnul.fs.address_.Shield.FroAddress(container)
				);

				//nilnul.fs.folder.dir._DropX.Drop(
				//	nilnul.fs.Folder.FroAddress(
				//		container
				//	)
				//	,
				//	nilnul.fs._address.Dir.OvDenote(
				//		dnt
				//	)

				//);
				Trace.TraceInformation(
					$"tried to make {dnt} symlink from folder:{container}"
				);

			}
			catch (Exception)
			{
				Trace.TraceError(
					$"failed in trying make {dnt} symlink from folder:{container}; maybe you are attempting to drop a dir that this test is running at?"
				);
				//Trace.TraceError(
				//	$"drop failed of {dnt} from folder:{container}; maybe you are attempting to drop a dir that this test is running at?"
				//);

				//throw;
			}

/*
			var dnt4pcks = ".packages";
			Trace.TraceInformation(
				$"dropping {dnt4pcks} from folder:{container}"
			);
			try
			{
				nilnul.fs.folder.dir._DropX.Drop(
					nilnul.fs.Folder.FroAddress(
					container
					)

					,

					 nilnul.fs._address.Dir.OvDenote(
					dnt4pcks
					)

				);
				Trace.TraceInformation(
					$"dropped {dnt4pcks} from folder:{container}"
				);

			}
			catch (Exception)
			{
				Trace.TraceError(
					$"drop failed of {dnt4pcks} from folder:{container}; maybe you are attempting to drop a dir that this test is running at?"
				);

				//throw;
			}
*/
		}

		 static void Vod_assumeCsSynd(string container, StreamWriter log)
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

			var dnt = "packages";
			Trace.TraceInformation(
				$"dropping {dnt} from folder:{container}"
			);
			try
			{
				nilnul.fs.folder.dir._DropX.Drop(
					nilnul.fs.Folder.FroAddress(
					container
					)

					,

					 nilnul.fs._address.Dir.OvDenote(
					dnt
					)

				);
				Trace.TraceInformation(
					$"dropped {dnt} from folder:{container}"
				);

			}
			catch (Exception)
			{
				Trace.TraceError(
					$"drop failed of {dnt} from folder:{container}; maybe you are attempting to drop a dir that this test is running at?"
				);

				//throw;
			}
		}
	}
}
