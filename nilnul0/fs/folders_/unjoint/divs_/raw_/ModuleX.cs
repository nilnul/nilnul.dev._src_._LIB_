﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.fs.folders_.unjoint.divs_.raw_
{
	 static public class ModuleX
	{
		static public IEnumerable<string> Seq(
			
			_unjoint.Io io
		) {


			return new Module(io).insideModules();
		


		}

		static public IEnumerable<string> Seq(
			IEnumerable<string> foldersIsolated
			
		) {
			///add actual trees.
			///

			return Seq(
				
				 _unjoint.Io.OfAddresses_removeNonfolder(
				foldersIsolated
			));
		}
		static public IEnumerable<string> Seq(
			params string[] foldersIsolated
			
		) {
			///add actual trees.
			///

			return Seq(
				
				(IEnumerable<string>)foldersIsolated
			);
		}


		public static IEnumerable<string> Seq(
			IEnumerable<string> folders
			,
			StreamWriter log
		)
		{
			return Seq(
				
				 _unjoint.Io.OfAddresses_removeNonfolder(
				folders,log
			));


		}
	}
}
