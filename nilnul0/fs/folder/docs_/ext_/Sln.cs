using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folder.docs_.ext_
{
	/// <summary>
	/// list all ".sln" files
	/// </summary>
	static public class _SlnX
	{
		public const string SLN = ".sln";
		static public IEnumerable<string> Captions(nilnul.fs.FolderI folder) {
			return nilnul.fs.folder.docs_._ExtX.Denotes(folder, ".sln");
		}
		static public IEnumerable<string> Captions(nilnul.fs.FolderI1 folder) {
			return nilnul.fs.folder.docs_._ExtX.Captions(folder, SLN);
			//return nilnul.fs.folder.docs_._ExtX.Denotes(folder, ".sln");
		}
		static public IEnumerable<string> Captions(nilnul.fs.address_.ShieldI1 folder) {
			return nilnul.fs.folder.docs_._ExtX.Captions(folder, SLN);
			//return nilnul.fs.folder.docs_._ExtX.Denotes(folder, ".sln");
		}

		static public IEnumerable<string> Captions_folderOfAddress(string folder) {
			return nilnul.fs.folder.docs_._ExtX.Denotes_ofAddress(folder, SLN);
			//return nilnul.fs.folder.docs_._ExtX.Denotes(folder, ".sln");
		}


	}
}
